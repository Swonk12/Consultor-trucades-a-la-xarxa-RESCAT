using Consultor_trucades_a_la_xarxa_RESCAT.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Consultor_trucades_a_la_xarxa_RESCAT
{
    public partial class FrmMain : Form
    {

        private string fileName;

        List <string> any2 = new List<string>();
        FrmGrafic fGrafic;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chkFiltre.Enabled = false;
            btExportar.Enabled = false;
            gbButtons.Enabled = false;
            cambiEstatGP();

            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = false;
            }

        }

        private void cambiEstatGP()
        {
            bool desactivar = chkFiltre.Checked;

            gpInfo.Enabled = !desactivar;
            GpDates.Enabled = !desactivar;
            GpEspera.Enabled = !desactivar;
            lbAny.Enabled = !desactivar;
            nupAny.Enabled = !desactivar;
            btCerca.Enabled = !desactivar;
            chkFiltreDades.Enabled = !desactivar;
            chkFiltreDades.Checked = false;
            GpDates.Enabled = false;
        }

        private void chkFiltre_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar/Deshabilitar filtres
            cambiEstatGP();

            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = false;
            }
            else
            {
                dgDades.Rows.Clear();
                omplirDataGrip();
            }

            // Ajustar la data Maxima
            DataMax();

        }

        private void DataMax()
        {
            // Cargar el documento XML
            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navegador = document.CreateNavigator();

            string fechaMaxima = "0000-00";

            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");
            expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);
            foreach (XPathNavigator row in cursor)
            {
                string data = row.SelectSingleNode("data")?.Value;
                DateTime dataConvert = DateTime.Parse(data);
                string dataTallada = dataConvert.ToString("yyyy-MM");

                if (string.Compare(dataTallada, fechaMaxima) > 0)
                {
                    fechaMaxima = dataTallada;
                }
            }

            int any = int.Parse(fechaMaxima.Split('-')[0]);

            nupAny.Value = any;
        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            if (dlgFitxer.ShowDialog() == DialogResult.OK)
            {
                // Gestionar la ruta
                tbRuta.Text = dlgFitxer.FileName;
                fileName = dlgFitxer.FileName;
                gpRuta.Enabled = false;

                // Habilitem el check de filtrar tot o res
                gbButtons.Enabled = true;
                chkFiltre.Enabled = true;

                btExportar.Enabled = true;

                omplirDataGrip();
            }
        }

        private void omplirDataGrip()
        {
            // Cargar el documento XML
            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navegador = document.CreateNavigator();

            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");
            expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);
            foreach (XPathNavigator row in cursor)
            {
                string data = row.SelectSingleNode("data")?.Value;
                DateTime dataConvert = DateTime.Parse(data);
                string dataTallada = dataConvert.ToString("yyyy-MM");

                string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

            }
        }

        private void chkFiltreDades_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltreDades.Checked == true)
            {
                GpDates.Enabled = true;
                nupAny.Enabled = false;
                lbAny.Enabled = false;
            }
            else
            {
                GpDates.Enabled = false;
                nupAny.Enabled = true;
                lbAny.Enabled = true;
            }
        }

        private void btCerca_Click(object sender, EventArgs e)
        {
            if (!chkFiltreDades.Checked)
            {
                // Filtro Año

                // Cargar el documento XML
                XPathDocument document = new XPathDocument(fileName);
                XPathNavigator navegador = document.CreateNavigator();

                dgDades.Rows.Clear();

                int contador = 0;
                double mitjaCua = 0;
                int TrucadesAny = 0;
                double tbs = 0, dots = 0, dxt = 0;

                XPathNodeIterator cursor = null;
                XPathExpression expr = navegador.Compile("//row//row");
                expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
                cursor = navegador.Select(expr);
                foreach (XPathNavigator row in cursor)
                {
                    string data = row.SelectSingleNode("data")?.Value;
                    DateTime dataConvert = DateTime.Parse(data);
                    string dataTallada = dataConvert.ToString("yyyy-MM");
                    int any = int.Parse(dataTallada.Split('-')[0]);
                    double cuaTime = Math.Round(double.Parse(row.SelectSingleNode("temps_mig_en_cua_segons").Value.Replace(".", ",")), 2);

                    if (any == nupAny.Value && (double)nupMin.Value == 0.00 && (double)nupMax.Value == 0.00)
                    {
                        contador = contador + 1;

                        string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                        string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                        string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                        string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                        string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                        string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                        double Cua = Convert.ToDouble(TempsMigCua, CultureInfo.InvariantCulture);
                        mitjaCua = mitjaCua + Cua;

                        TrucadesAny = TrucadesAny + int.Parse(NombreTrucades);

                        tbs += Convert.ToDouble(disponibilitatTbs, CultureInfo.InvariantCulture);
                        dots += Convert.ToDouble(disponibilitatDots, CultureInfo.InvariantCulture);
                        dxt += Convert.ToDouble(disponibilitatDxt, CultureInfo.InvariantCulture);

                        dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

                        lbMitjaCua.Text = contador > 0 ? Math.Round(mitjaCua / contador, 2).ToString() + " segons" : "0 segons";
                        lbMitjaTrucades.Text = contador > 0 ? (TrucadesAny / contador).ToString() : "0";
                        lbTBS.Text = contador > 0 ? Math.Round((tbs / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDOTS.Text = contador > 0 ? Math.Round((dots / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDXT.Text = contador > 0 ? Math.Round((dxt / contador) * 1000, 2).ToString() + "  /  1000" : "0";

                    }
                    else if (any == nupAny.Value && ((double)nupMin.Value != 0.00 || (double)nupMax.Value != 0.00) && (double)nupMin.Value <= cuaTime && (double)nupMax.Value >= cuaTime)
                    {
                        contador = contador + 1;

                        string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                        string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                        string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                        string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                        string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                        string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                        double Cua = Convert.ToDouble(TempsMigCua, CultureInfo.InvariantCulture);
                        mitjaCua = mitjaCua + Cua;

                        TrucadesAny = TrucadesAny + int.Parse(NombreTrucades);

                        tbs += Convert.ToDouble(disponibilitatTbs, CultureInfo.InvariantCulture);
                        dots += Convert.ToDouble(disponibilitatDots, CultureInfo.InvariantCulture);
                        dxt += Convert.ToDouble(disponibilitatDxt, CultureInfo.InvariantCulture);

                        dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

                        lbMitjaCua.Text = contador > 0 ? Math.Round(mitjaCua / contador, 2).ToString() + " segons" : "0 segons";
                        lbMitjaTrucades.Text = contador > 0 ? (TrucadesAny / contador).ToString() : "0";
                        lbTBS.Text = contador > 0 ? Math.Round((tbs / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDOTS.Text = contador > 0 ? Math.Round((dots / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDXT.Text = contador > 0 ? Math.Round((dxt / contador) * 1000, 2).ToString() + "  /  1000" : "0";

                    }

                }
            }
            else
            {
                // Filtro fechas en concreto
                // Filtro Año

                // Cargar el documento XML
                XPathDocument document = new XPathDocument(fileName);
                XPathNavigator navegador = document.CreateNavigator();

                dgDades.Rows.Clear();

                int contador = 0;
                double mitjaCua = 0;
                int TrucadesAny = 0;
                double tbs = 0, dots = 0, dxt = 0;

                XPathNodeIterator cursor = null;
                XPathExpression expr = navegador.Compile("//row//row");
                expr.AddSort("data", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
                cursor = navegador.Select(expr);
                foreach (XPathNavigator row in cursor)
                {
                    string data = row.SelectSingleNode("data")?.Value;
                    DateTime dataConvert = DateTime.Parse(data);
                    string dataTallada = dataConvert.ToString("yyyy-MM-dd");
                    double cuaTime = Math.Round(double.Parse(row.SelectSingleNode("temps_mig_en_cua_segons").Value.Replace(".", ",")), 2);

                    DateTime dateFil1 = DTini.Value;
                    DateTime dateFil2 = DTend.Value;



                    if (dataConvert >= dateFil1 && dataConvert <= dateFil2 && (double)nupMin.Value == 0.00 && (double)nupMax.Value == 0.00)
                    {
                        contador = contador + 1;

                        string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                        string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                        string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                        string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                        string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                        string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                        double Cua = Convert.ToDouble(TempsMigCua, CultureInfo.InvariantCulture);
                        mitjaCua = mitjaCua + Cua;

                        TrucadesAny = TrucadesAny + int.Parse(NombreTrucades);

                        tbs += Convert.ToDouble(disponibilitatTbs, CultureInfo.InvariantCulture);
                        dots += Convert.ToDouble(disponibilitatDots, CultureInfo.InvariantCulture);
                        dxt += Convert.ToDouble(disponibilitatDxt, CultureInfo.InvariantCulture);

                        dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

                        lbMitjaCua.Text = contador > 0 ? Math.Round(mitjaCua / contador, 2).ToString() + " segons" : "0 segons";
                        lbMitjaTrucades.Text = contador > 0 ? (TrucadesAny / contador).ToString() : "0";
                        lbTBS.Text = contador > 0 ? Math.Round((tbs / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDOTS.Text = contador > 0 ? Math.Round((dots / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDXT.Text = contador > 0 ? Math.Round((dxt / contador) * 1000, 2).ToString() + "  /  1000" : "0";

                    }
                    else if (dataConvert >= dateFil1 && dataConvert <= dateFil2 && ((double)nupMin.Value != 0.00 || (double)nupMax.Value != 0.00) && (double)nupMin.Value <= cuaTime && (double)nupMax.Value >= cuaTime)
                    {
                        contador = contador + 1;

                        string NombreTrucades = row.SelectSingleNode("nombre_total_de_trucades")?.Value;
                        string TempsTrucades = row.SelectSingleNode("temps_total_de_trucades_grup")?.Value;
                        string TempsMigCua = row.SelectSingleNode("temps_mig_en_cua_segons")?.Value;
                        string disponibilitatTbs = row.SelectSingleNode("disponibilitat_tbs")?.Value;
                        string disponibilitatDots = row.SelectSingleNode("disponibilitat_dots_1")?.Value;
                        string disponibilitatDxt = row.SelectSingleNode("disponibilitat_tbs")?.Value;

                        double Cua = Convert.ToDouble(TempsMigCua, CultureInfo.InvariantCulture);
                        mitjaCua = mitjaCua + Cua;

                        TrucadesAny = TrucadesAny + int.Parse(NombreTrucades);

                        tbs += Convert.ToDouble(disponibilitatTbs, CultureInfo.InvariantCulture);
                        dots += Convert.ToDouble(disponibilitatDots, CultureInfo.InvariantCulture);
                        dxt += Convert.ToDouble(disponibilitatDxt, CultureInfo.InvariantCulture);

                        dgDades.Rows.Add(dataTallada, NombreTrucades, TempsTrucades, TempsMigCua, disponibilitatTbs, disponibilitatDots, disponibilitatDxt);

                        lbMitjaCua.Text = contador > 0 ? Math.Round(mitjaCua / contador, 2).ToString() + " segons" : "0 segons";
                        lbMitjaTrucades.Text = contador > 0 ? (TrucadesAny / contador).ToString() : "0";
                        lbTBS.Text = contador > 0 ? Math.Round((tbs / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDOTS.Text = contador > 0 ? Math.Round((dots / contador) * 1000, 2).ToString() + "  /  1000" : "0";
                        lbDXT.Text = contador > 0 ? Math.Round((dxt / contador) * 1000, 2).ToString() + "  /  1000" : "0";

                    }

                }



            }
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count == 0)
            {
                MessageBox.Show("Falta agregar datos a la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlDocument xDoc = new XmlDocument();
                XmlDeclaration xDeclaracio = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xDoc.AppendChild(xDeclaracio);

                XmlElement root = xDoc.CreateElement("recollida");
                xDoc.AppendChild(root);

                XmlElement rower = xDoc.CreateElement("row");
                root.AppendChild(rower);
                foreach (DataGridViewRow row in dgDades.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null)
                        continue;

                    XmlElement filaXML = xDoc.CreateElement("row");

                    // Agregar cada celda como un nodo XML
                    for (int i = 0; i < dgDades.Columns.Count; i++)
                    {
                        // Corregimos el nombre de la columna (quitamos espacios)
                        string nombreColumna = dgDades.Columns[i].HeaderText.Replace(" ", "_");
                        string valorCelda = row.Cells[i].Value?.ToString() ?? "";

                        XmlElement celdaXML = xDoc.CreateElement(nombreColumna);
                        celdaXML.InnerText = valorCelda;
                        filaXML.AppendChild(celdaXML);
                    }

                    rower.AppendChild(filaXML);
                }            
                xDoc.Save("recollida.xml");
                MessageBox.Show("El archivo 'recollida.xml' se ha generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            Process[] proces = Process.GetProcessesByName("Calculator");

            if (proces.Length == 0)
            {
                Process.Start("calc.exe");
            }
        }

        private void pbMaps_Click(object sender, EventArgs e)
        {
            string url = "https://analisi.transparenciacatalunya.cat/Seguretat/Disponibilitat-i-trucades-a-la-xarxa-RESCAT/93rs-9s9d/about_data";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btMit_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count == 0)
            {
                MessageBox.Show("Falta agregar datos a la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlDocument xDoc = new XmlDocument();
                XmlDeclaration xDeclaracio = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xDoc.AppendChild(xDeclaracio);

                XPathDocument document = new XPathDocument(fileName);
                XPathNavigator navegador = document.CreateNavigator();
                XPathNodeIterator cursor = null;
                XPathExpression expr = navegador.Compile("//response/row/row");

                XmlElement root = xDoc.CreateElement("Mitjes");
                xDoc.AppendChild(root);

                expr.AddSort("row", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

                XmlElement mitjCua = xDoc.CreateElement("MitjaCua");
                mitjCua.InnerText = lbMitjaCua.Text;
                root.AppendChild(mitjCua);

                XmlElement mitjTrucades = xDoc.CreateElement("MitjTrucades");
                mitjTrucades.InnerText = lbMitjaTrucades.Text;
                root.AppendChild(mitjTrucades);

                XmlElement mitjTBS = xDoc.CreateElement("MitjTBS");
                mitjTBS.InnerText = lbTBS.Text;
                root.AppendChild(mitjTBS);

                XmlElement mitjDOTS = xDoc.CreateElement("MitjDOTS");
                mitjDOTS.InnerText = lbDOTS.Text;
                root.AppendChild(mitjDOTS);

                XmlElement mitjDXT = xDoc.CreateElement("MitjOXT");
                mitjDXT.InnerText = lbDXT.Text;
                root.AppendChild(mitjDXT);

                xDoc.Save("mitjes.xml");
                MessageBox.Show("El archivo 'any.xml' se ha generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAnys_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlDeclaration xDeclaracio = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xDoc.AppendChild(xDeclaracio);

            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navegador = document.CreateNavigator();
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//response/row/row");

            XmlElement root = xDoc.CreateElement("Anys");
            xDoc.AppendChild(root);

            expr.AddSort("row", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);
            any2.Clear();
            foreach (XPathNavigator tut in cursor)
            {
                string data = tut.SelectSingleNode("data")?.Value;
                DateTime dataConvert = DateTime.Parse(data);
                string dataTallada = dataConvert.ToString("yyyy");

                if (!any2.Contains(dataTallada))
                {
                    any2.Add(dataTallada);
                    XmlElement anyXML = xDoc.CreateElement("data");
                    anyXML.InnerText = dataTallada;
                    root.AppendChild(anyXML);
                }
            }
            xDoc.Save("any.xml");
            MessageBox.Show("El archivo 'any.xml' se ha generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btGrafic_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count == 0)
            {
                MessageBox.Show("Falta agregar datos a la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //List<string> etiquetasX = new List<string>();
                //List<double> valoresY = new List<double>();

                //XPathDocument document = new XPathDocument(fileName);
                //XPathNavigator navegador = document.CreateNavigator();
                //XPathNodeIterator cursor = null;
                //XPathExpression expr = navegador.Compile("//response/row/row");


                //expr.AddSort("row", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
                //cursor = navegador.Select(expr);
                //valoresY.Clear();
                //foreach (XPathNavigator tut in cursor)
                //{
                //    string data = tut.SelectSingleNode("data")?.Value;
                //    DateTime dataConvert = DateTime.Parse(data);
                //    string dataTallada = dataConvert.ToString("yyyy");

                //    if (!etiquetasX.Contains(dataTallada))
                //    {
                //        etiquetasX.Add(dataTallada);
                //        valoresY.Add(((double)navegador.Evaluate($"AVG(//data LIKE '{data}%']/temps_mig_en_cua_segons)")));
                //    }
                //}

                List<string> etiquetasX = new List<string>();
                List<double> valoresY = new List<double>();

                XPathDocument document = new XPathDocument(fileName);
                XPathNavigator navegador = document.CreateNavigator();
                XPathNodeIterator cursor = navegador.Select("//response/row/row");

                valoresY.Clear();

                Dictionary<string, List<double>> datosAgrupados = new Dictionary<string, List<double>>();

                foreach (XPathNavigator tut in cursor)
                {
                    string data = tut.SelectSingleNode("data")?.Value;
                    string temps = tut.SelectSingleNode("temps_mig_en_cua_segons")?.Value;

                    if (DateTime.TryParse(data, out DateTime dataConvert) && double.TryParse(temps, NumberStyles.Any, CultureInfo.InvariantCulture, out double tempsValor))
                    {
                        string dataTallada = dataConvert.ToString("yyyy"); // Extraer solo el año

                        if (!datosAgrupados.ContainsKey(dataTallada))
                        {
                            datosAgrupados[dataTallada] = new List<double>();
                        }

                        datosAgrupados[dataTallada].Add(tempsValor);
                    }
                }

                // Calcular el promedio por año
                foreach (var entry in datosAgrupados)
                {
                    etiquetasX.Add(entry.Key);
                    valoresY.Add(entry.Value.Count > 0 ? entry.Value.Average() : 0);
                }

                fGrafic = new FrmGrafic(etiquetasX, valoresY);
                fGrafic.Name = "Grafico";
                fGrafic.Show();
                fGrafic.Activate();
            }
        }
    }
}