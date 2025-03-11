namespace Consultor_trucades_a_la_xarxa_RESCAT
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GpDates = new System.Windows.Forms.GroupBox();
            this.DTend = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.DTini = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.lbDXT = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbDOTS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTBS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMitjaTrucades = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMitjaCua = new System.Windows.Forms.Label();
            this.lbdada = new System.Windows.Forms.Label();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTrucades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempsTrucades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempsMigCua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilitatTbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilitatDots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilitatDxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpRuta = new System.Windows.Forms.GroupBox();
            this.btExaminar = new System.Windows.Forms.Button();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.lbAny = new System.Windows.Forms.Label();
            this.nupAny = new System.Windows.Forms.NumericUpDown();
            this.chkFiltre = new System.Windows.Forms.CheckBox();
            this.dlgFitxer = new System.Windows.Forms.OpenFileDialog();
            this.btCerca = new System.Windows.Forms.Button();
            this.chkFiltreDades = new System.Windows.Forms.CheckBox();
            this.btExportar = new System.Windows.Forms.Button();
            this.GpEspera = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupMax = new System.Windows.Forms.NumericUpDown();
            this.nupMin = new System.Windows.Forms.NumericUpDown();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btAnys = new System.Windows.Forms.Button();
            this.btMit = new System.Windows.Forms.Button();
            this.btGrafic = new System.Windows.Forms.Button();
            this.pbMaps = new System.Windows.Forms.PictureBox();
            this.pbCalculadora = new System.Windows.Forms.PictureBox();
            this.GpDates.SuspendLayout();
            this.gpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gpRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAny)).BeginInit();
            this.GpEspera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMin)).BeginInit();
            this.gbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).BeginInit();
            this.SuspendLayout();
            // 
            // GpDates
            // 
            this.GpDates.Controls.Add(this.DTend);
            this.GpDates.Controls.Add(this.label17);
            this.GpDates.Controls.Add(this.DTini);
            this.GpDates.Controls.Add(this.label7);
            this.GpDates.Location = new System.Drawing.Point(709, 12);
            this.GpDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpDates.Name = "GpDates";
            this.GpDates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpDates.Size = new System.Drawing.Size(248, 84);
            this.GpDates.TabIndex = 0;
            this.GpDates.TabStop = false;
            this.GpDates.Text = "Rang Dates";
            // 
            // DTend
            // 
            this.DTend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTend.Location = new System.Drawing.Point(113, 52);
            this.DTend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTend.Name = "DTend";
            this.DTend.Size = new System.Drawing.Size(101, 22);
            this.DTend.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Data Final:";
            // 
            // DTini
            // 
            this.DTini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTini.Location = new System.Drawing.Point(113, 21);
            this.DTini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTini.Name = "DTini";
            this.DTini.Size = new System.Drawing.Size(101, 22);
            this.DTini.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data Inicial:";
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.lbDXT);
            this.gpInfo.Controls.Add(this.label16);
            this.gpInfo.Controls.Add(this.lbDOTS);
            this.gpInfo.Controls.Add(this.label11);
            this.gpInfo.Controls.Add(this.lbTBS);
            this.gpInfo.Controls.Add(this.label9);
            this.gpInfo.Controls.Add(this.lbMitjaTrucades);
            this.gpInfo.Controls.Add(this.label5);
            this.gpInfo.Controls.Add(this.lbMitjaCua);
            this.gpInfo.Controls.Add(this.lbdada);
            this.gpInfo.Location = new System.Drawing.Point(12, 74);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpInfo.Size = new System.Drawing.Size(501, 100);
            this.gpInfo.TabIndex = 3;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Informació Filtrada";
            // 
            // lbDXT
            // 
            this.lbDXT.AutoSize = true;
            this.lbDXT.Location = new System.Drawing.Point(344, 74);
            this.lbDXT.Name = "lbDXT";
            this.lbDXT.Size = new System.Drawing.Size(24, 16);
            this.lbDXT.TabIndex = 13;
            this.lbDXT.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(245, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Mitja DXT:";
            // 
            // lbDOTS
            // 
            this.lbDOTS.AutoSize = true;
            this.lbDOTS.Location = new System.Drawing.Point(344, 48);
            this.lbDOTS.Name = "lbDOTS";
            this.lbDOTS.Size = new System.Drawing.Size(24, 16);
            this.lbDOTS.TabIndex = 10;
            this.lbDOTS.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Mitja Dots:";
            // 
            // lbTBS
            // 
            this.lbTBS.AutoSize = true;
            this.lbTBS.Location = new System.Drawing.Point(344, 20);
            this.lbTBS.Name = "lbTBS";
            this.lbTBS.Size = new System.Drawing.Size(24, 16);
            this.lbTBS.TabIndex = 6;
            this.lbTBS.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mitja TBS:";
            // 
            // lbMitjaTrucades
            // 
            this.lbMitjaTrucades.AutoSize = true;
            this.lbMitjaTrucades.Location = new System.Drawing.Point(155, 66);
            this.lbMitjaTrucades.Name = "lbMitjaTrucades";
            this.lbMitjaTrucades.Size = new System.Drawing.Size(73, 16);
            this.lbMitjaTrucades.TabIndex = 4;
            this.lbMitjaTrucades.Text = "0000000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mitja Trucades:";
            // 
            // lbMitjaCua
            // 
            this.lbMitjaCua.AutoSize = true;
            this.lbMitjaCua.Location = new System.Drawing.Point(109, 32);
            this.lbMitjaCua.Name = "lbMitjaCua";
            this.lbMitjaCua.Size = new System.Drawing.Size(38, 16);
            this.lbMitjaCua.TabIndex = 1;
            this.lbMitjaCua.Text = "00.00";
            // 
            // lbdada
            // 
            this.lbdada.AutoSize = true;
            this.lbdada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdada.Location = new System.Drawing.Point(29, 32);
            this.lbdada.Name = "lbdada";
            this.lbdada.Size = new System.Drawing.Size(75, 16);
            this.lbdada.TabIndex = 0;
            this.lbdada.Text = "Mitja Cua:";
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDades.ColumnHeadersHeight = 29;
            this.dgDades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.NombreTrucades,
            this.TempsTrucades,
            this.TempsMigCua,
            this.disponibilitatTbs,
            this.disponibilitatDots,
            this.disponibilitatDxt});
            this.dgDades.Location = new System.Drawing.Point(12, 185);
            this.dgDades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.RowTemplate.Height = 24;
            this.dgDades.Size = new System.Drawing.Size(1124, 288);
            this.dgDades.TabIndex = 4;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 65;
            // 
            // NombreTrucades
            // 
            this.NombreTrucades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NombreTrucades.HeaderText = "Nom Trucades";
            this.NombreTrucades.MinimumWidth = 6;
            this.NombreTrucades.Name = "NombreTrucades";
            this.NombreTrucades.ReadOnly = true;
            this.NombreTrucades.Width = 126;
            // 
            // TempsTrucades
            // 
            this.TempsTrucades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TempsTrucades.HeaderText = "Temps Trucades";
            this.TempsTrucades.MinimumWidth = 6;
            this.TempsTrucades.Name = "TempsTrucades";
            this.TempsTrucades.ReadOnly = true;
            this.TempsTrucades.Width = 140;
            // 
            // TempsMigCua
            // 
            this.TempsMigCua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TempsMigCua.HeaderText = "Temps Mig Cua";
            this.TempsMigCua.MinimumWidth = 6;
            this.TempsMigCua.Name = "TempsMigCua";
            this.TempsMigCua.ReadOnly = true;
            this.TempsMigCua.Width = 131;
            // 
            // disponibilitatTbs
            // 
            this.disponibilitatTbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.disponibilitatTbs.HeaderText = "disponibilitat TBS";
            this.disponibilitatTbs.MinimumWidth = 6;
            this.disponibilitatTbs.Name = "disponibilitatTbs";
            this.disponibilitatTbs.ReadOnly = true;
            this.disponibilitatTbs.Width = 141;
            // 
            // disponibilitatDots
            // 
            this.disponibilitatDots.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.disponibilitatDots.HeaderText = "disponibilitat DOTS";
            this.disponibilitatDots.MinimumWidth = 6;
            this.disponibilitatDots.Name = "disponibilitatDots";
            this.disponibilitatDots.ReadOnly = true;
            this.disponibilitatDots.Width = 152;
            // 
            // disponibilitatDxt
            // 
            this.disponibilitatDxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.disponibilitatDxt.HeaderText = "disponibilitat DXT";
            this.disponibilitatDxt.MinimumWidth = 6;
            this.disponibilitatDxt.Name = "disponibilitatDxt";
            this.disponibilitatDxt.ReadOnly = true;
            this.disponibilitatDxt.Width = 141;
            // 
            // gpRuta
            // 
            this.gpRuta.Controls.Add(this.btExaminar);
            this.gpRuta.Controls.Add(this.tbRuta);
            this.gpRuta.Location = new System.Drawing.Point(12, 6);
            this.gpRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpRuta.Name = "gpRuta";
            this.gpRuta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpRuta.Size = new System.Drawing.Size(692, 58);
            this.gpRuta.TabIndex = 5;
            this.gpRuta.TabStop = false;
            this.gpRuta.Text = "fitxer XML";
            // 
            // btExaminar
            // 
            this.btExaminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExaminar.Location = new System.Drawing.Point(571, 17);
            this.btExaminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(116, 31);
            this.btExaminar.TabIndex = 1;
            this.btExaminar.Text = "Examinar";
            this.btExaminar.UseVisualStyleBackColor = false;
            this.btExaminar.Click += new System.EventHandler(this.btExaminar_Click);
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(5, 21);
            this.tbRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(547, 22);
            this.tbRuta.TabIndex = 0;
            // 
            // lbAny
            // 
            this.lbAny.AutoSize = true;
            this.lbAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAny.Location = new System.Drawing.Point(765, 148);
            this.lbAny.Name = "lbAny";
            this.lbAny.Size = new System.Drawing.Size(41, 16);
            this.lbAny.TabIndex = 1;
            this.lbAny.Text = "Any: ";
            // 
            // nupAny
            // 
            this.nupAny.Location = new System.Drawing.Point(812, 146);
            this.nupAny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupAny.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nupAny.Name = "nupAny";
            this.nupAny.Size = new System.Drawing.Size(101, 22);
            this.nupAny.TabIndex = 2;
            this.nupAny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupAny.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // chkFiltre
            // 
            this.chkFiltre.AutoSize = true;
            this.chkFiltre.Checked = true;
            this.chkFiltre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltre.Location = new System.Drawing.Point(299, 486);
            this.chkFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFiltre.Name = "chkFiltre";
            this.chkFiltre.Size = new System.Drawing.Size(133, 20);
            this.chkFiltre.TabIndex = 6;
            this.chkFiltre.Text = "SENSE FILTRES";
            this.chkFiltre.UseVisualStyleBackColor = true;
            this.chkFiltre.CheckedChanged += new System.EventHandler(this.chkFiltre_CheckedChanged);
            // 
            // btCerca
            // 
            this.btCerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCerca.Location = new System.Drawing.Point(968, 25);
            this.btCerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCerca.Name = "btCerca";
            this.btCerca.Size = new System.Drawing.Size(168, 62);
            this.btCerca.TabIndex = 7;
            this.btCerca.Text = "CERCA";
            this.btCerca.UseVisualStyleBackColor = false;
            this.btCerca.Click += new System.EventHandler(this.btCerca_Click);
            // 
            // chkFiltreDades
            // 
            this.chkFiltreDades.AutoSize = true;
            this.chkFiltreDades.Location = new System.Drawing.Point(731, 105);
            this.chkFiltreDades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFiltreDades.Name = "chkFiltreDades";
            this.chkFiltreDades.Size = new System.Drawing.Size(224, 20);
            this.chkFiltreDades.TabIndex = 8;
            this.chkFiltreDades.Text = "FILTRE DATES ESPECIFIQUES";
            this.chkFiltreDades.UseVisualStyleBackColor = true;
            this.chkFiltreDades.CheckedChanged += new System.EventHandler(this.chkFiltreDades_CheckedChanged);
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btExportar.Location = new System.Drawing.Point(968, 106);
            this.btExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(168, 62);
            this.btExportar.TabIndex = 9;
            this.btExportar.Text = "EXPORTAR";
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // GpEspera
            // 
            this.GpEspera.Controls.Add(this.label2);
            this.GpEspera.Controls.Add(this.label1);
            this.GpEspera.Controls.Add(this.nupMax);
            this.GpEspera.Controls.Add(this.nupMin);
            this.GpEspera.Location = new System.Drawing.Point(524, 79);
            this.GpEspera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpEspera.Name = "GpEspera";
            this.GpEspera.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpEspera.Size = new System.Drawing.Size(180, 95);
            this.GpEspera.TabIndex = 10;
            this.GpEspera.TabStop = false;
            this.GpEspera.Text = "Temps Espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cua Maxima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cua Minima:";
            // 
            // nupMax
            // 
            this.nupMax.DecimalPlaces = 2;
            this.nupMax.Location = new System.Drawing.Point(104, 63);
            this.nupMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupMax.Name = "nupMax";
            this.nupMax.Size = new System.Drawing.Size(55, 22);
            this.nupMax.TabIndex = 1;
            // 
            // nupMin
            // 
            this.nupMin.DecimalPlaces = 2;
            this.nupMin.Location = new System.Drawing.Point(104, 27);
            this.nupMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupMin.Name = "nupMin";
            this.nupMin.Size = new System.Drawing.Size(55, 22);
            this.nupMin.TabIndex = 0;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btGrafic);
            this.gbButtons.Controls.Add(this.pbMaps);
            this.gbButtons.Controls.Add(this.pbCalculadora);
            this.gbButtons.Controls.Add(this.btAnys);
            this.gbButtons.Controls.Add(this.btMit);
            this.gbButtons.Location = new System.Drawing.Point(12, 511);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(1124, 100);
            this.gbButtons.TabIndex = 11;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Aditional buttons";
            // 
            // btAnys
            // 
            this.btAnys.BackColor = System.Drawing.Color.Peru;
            this.btAnys.Location = new System.Drawing.Point(220, 26);
            this.btAnys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnys.Name = "btAnys";
            this.btAnys.Size = new System.Drawing.Size(168, 62);
            this.btAnys.TabIndex = 9;
            this.btAnys.Text = "Anys Recollits";
            this.btAnys.UseVisualStyleBackColor = false;
            this.btAnys.Click += new System.EventHandler(this.btAnys_Click);
            // 
            // btMit
            // 
            this.btMit.BackColor = System.Drawing.Color.OrangeRed;
            this.btMit.Location = new System.Drawing.Point(15, 26);
            this.btMit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMit.Name = "btMit";
            this.btMit.Size = new System.Drawing.Size(168, 62);
            this.btMit.TabIndex = 8;
            this.btMit.Text = "Mitjes";
            this.btMit.UseVisualStyleBackColor = false;
            this.btMit.Click += new System.EventHandler(this.btMit_Click);
            // 
            // btGrafic
            // 
            this.btGrafic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGrafic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrafic.Location = new System.Drawing.Point(415, 12);
            this.btGrafic.Name = "btGrafic";
            this.btGrafic.Size = new System.Drawing.Size(631, 82);
            this.btGrafic.TabIndex = 12;
            this.btGrafic.Text = "Grafic";
            this.btGrafic.UseVisualStyleBackColor = false;
            this.btGrafic.Click += new System.EventHandler(this.btGrafic_Click);
            // 
            // pbMaps
            // 
            this.pbMaps.Image = ((System.Drawing.Image)(resources.GetObject("pbMaps.Image")));
            this.pbMaps.Location = new System.Drawing.Point(1064, 11);
            this.pbMaps.Name = "pbMaps";
            this.pbMaps.Size = new System.Drawing.Size(52, 42);
            this.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaps.TabIndex = 11;
            this.pbMaps.TabStop = false;
            this.pbMaps.Click += new System.EventHandler(this.pbMaps_Click);
            // 
            // pbCalculadora
            // 
            this.pbCalculadora.Image = global::Consultor_trucades_a_la_xarxa_RESCAT.Properties.Resources.calulate;
            this.pbCalculadora.Location = new System.Drawing.Point(1063, 54);
            this.pbCalculadora.Name = "pbCalculadora";
            this.pbCalculadora.Size = new System.Drawing.Size(52, 42);
            this.pbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalculadora.TabIndex = 10;
            this.pbCalculadora.TabStop = false;
            this.pbCalculadora.Click += new System.EventHandler(this.pbCalculadora_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 635);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.GpEspera);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.chkFiltreDades);
            this.Controls.Add(this.btCerca);
            this.Controls.Add(this.chkFiltre);
            this.Controls.Add(this.gpRuta);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.nupAny);
            this.Controls.Add(this.lbAny);
            this.Controls.Add(this.GpDates);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Disponibilitat i trucades a la xarxa RESCAT";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GpDates.ResumeLayout(false);
            this.GpDates.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.gpRuta.ResumeLayout(false);
            this.gpRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAny)).EndInit();
            this.GpEspera.ResumeLayout(false);
            this.GpEspera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMin)).EndInit();
            this.gbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpDates;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.Label lbMitjaTrucades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMitjaCua;
        private System.Windows.Forms.Label lbdada;
        private System.Windows.Forms.DateTimePicker DTini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTBS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbDXT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbDOTS;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.GroupBox gpRuta;
        private System.Windows.Forms.Button btExaminar;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.Label lbAny;
        private System.Windows.Forms.NumericUpDown nupAny;
        private System.Windows.Forms.CheckBox chkFiltre;
        private System.Windows.Forms.OpenFileDialog dlgFitxer;
        private System.Windows.Forms.Button btCerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTrucades;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempsTrucades;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempsMigCua;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilitatTbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilitatDots;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilitatDxt;
        private System.Windows.Forms.CheckBox chkFiltreDades;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.GroupBox GpEspera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupMax;
        private System.Windows.Forms.NumericUpDown nupMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btAnys;
        private System.Windows.Forms.Button btMit;
        private System.Windows.Forms.PictureBox pbCalculadora;
        private System.Windows.Forms.PictureBox pbMaps;
        private System.Windows.Forms.Button btGrafic;
    }
}

