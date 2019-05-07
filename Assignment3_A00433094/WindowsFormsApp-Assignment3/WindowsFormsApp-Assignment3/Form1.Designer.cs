using System.Data;

namespace WindowsFormsApp_Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fIRSTNAMELabel;
            System.Windows.Forms.Label lASTNAMELabel;
            System.Windows.Forms.Label sTREETNAMELabel;
            System.Windows.Forms.Label sTREETLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label pROVINCELabel;
            System.Windows.Forms.Label cOUNTRYLabel;
            System.Windows.Forms.Label pOSTALCODELabel;
            System.Windows.Forms.Label pHONENUMBERLabel;
            System.Windows.Forms.Label eMAILLabel;
            this.assignment3DatabaseDataSet = new WindowsFormsApp_Assignment3.Assignment3DatabaseDataSet();
            this.assignment3TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment3TableTableAdapter = new WindowsFormsApp_Assignment3.Assignment3DatabaseDataSetTableAdapters.Assignment3TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Assignment3.Assignment3DatabaseDataSetTableAdapters.TableAdapterManager();
            this.fIRSTNAMETextBox = new System.Windows.Forms.TextBox();
            this.lASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.sTREETNAMETextBox = new System.Windows.Forms.TextBox();
            this.sTREETTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.pROVINCETextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRYTextBox = new System.Windows.Forms.TextBox();
            this.pOSTALCODETextBox = new System.Windows.Forms.TextBox();
            this.pHONENUMBERTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorsTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryKeyTxtBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.currentRecTxtBox = new System.Windows.Forms.TextBox();
            this.totalRecords = new System.Windows.Forms.Label();
            this.totalRecTxtBox = new System.Windows.Forms.TextBox();
            this.currentRecords = new System.Windows.Forms.Label();
            fIRSTNAMELabel = new System.Windows.Forms.Label();
            lASTNAMELabel = new System.Windows.Forms.Label();
            sTREETNAMELabel = new System.Windows.Forms.Label();
            sTREETLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            pROVINCELabel = new System.Windows.Forms.Label();
            cOUNTRYLabel = new System.Windows.Forms.Label();
            pOSTALCODELabel = new System.Windows.Forms.Label();
            pHONENUMBERLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignment3DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment3TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fIRSTNAMELabel
            // 
            fIRSTNAMELabel.AutoSize = true;
            fIRSTNAMELabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fIRSTNAMELabel.ForeColor = System.Drawing.SystemColors.Highlight;
            fIRSTNAMELabel.Location = new System.Drawing.Point(82, 53);
            fIRSTNAMELabel.Name = "fIRSTNAMELabel";
            fIRSTNAMELabel.Size = new System.Drawing.Size(103, 23);
            fIRSTNAMELabel.TabIndex = 1;
            fIRSTNAMELabel.Text = "FIRSTNAME:";
            // 
            // lASTNAMELabel
            // 
            lASTNAMELabel.AutoSize = true;
            lASTNAMELabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lASTNAMELabel.ForeColor = System.Drawing.SystemColors.Highlight;
            lASTNAMELabel.Location = new System.Drawing.Point(82, 99);
            lASTNAMELabel.Name = "lASTNAMELabel";
            lASTNAMELabel.Size = new System.Drawing.Size(99, 23);
            lASTNAMELabel.TabIndex = 3;
            lASTNAMELabel.Text = "LASTNAME:";
            // 
            // sTREETNAMELabel
            // 
            sTREETNAMELabel.AutoSize = true;
            sTREETNAMELabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTREETNAMELabel.ForeColor = System.Drawing.SystemColors.Highlight;
            sTREETNAMELabel.Location = new System.Drawing.Point(82, 151);
            sTREETNAMELabel.Name = "sTREETNAMELabel";
            sTREETNAMELabel.Size = new System.Drawing.Size(117, 23);
            sTREETNAMELabel.TabIndex = 5;
            sTREETNAMELabel.Text = "STREETNAME:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTREETLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            sTREETLabel.Location = new System.Drawing.Point(82, 199);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(69, 23);
            sTREETLabel.TabIndex = 7;
            sTREETLabel.Text = "STREET:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            cITYLabel.Location = new System.Drawing.Point(82, 245);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(48, 23);
            cITYLabel.TabIndex = 9;
            cITYLabel.Text = "CITY:";
            // 
            // pROVINCELabel
            // 
            pROVINCELabel.AutoSize = true;
            pROVINCELabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pROVINCELabel.ForeColor = System.Drawing.SystemColors.Highlight;
            pROVINCELabel.Location = new System.Drawing.Point(629, 50);
            pROVINCELabel.Name = "pROVINCELabel";
            pROVINCELabel.Size = new System.Drawing.Size(96, 23);
            pROVINCELabel.TabIndex = 11;
            pROVINCELabel.Text = "PROVINCE:";
            // 
            // cOUNTRYLabel
            // 
            cOUNTRYLabel.AutoSize = true;
            cOUNTRYLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOUNTRYLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            cOUNTRYLabel.Location = new System.Drawing.Point(629, 97);
            cOUNTRYLabel.Name = "cOUNTRYLabel";
            cOUNTRYLabel.Size = new System.Drawing.Size(91, 23);
            cOUNTRYLabel.TabIndex = 13;
            cOUNTRYLabel.Text = "COUNTRY:";
            // 
            // pOSTALCODELabel
            // 
            pOSTALCODELabel.AutoSize = true;
            pOSTALCODELabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pOSTALCODELabel.ForeColor = System.Drawing.SystemColors.Highlight;
            pOSTALCODELabel.Location = new System.Drawing.Point(629, 149);
            pOSTALCODELabel.Name = "pOSTALCODELabel";
            pOSTALCODELabel.Size = new System.Drawing.Size(117, 23);
            pOSTALCODELabel.TabIndex = 15;
            pOSTALCODELabel.Text = "POSTALCODE:";
            // 
            // pHONENUMBERLabel
            // 
            pHONENUMBERLabel.AutoSize = true;
            pHONENUMBERLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONENUMBERLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            pHONENUMBERLabel.Location = new System.Drawing.Point(629, 197);
            pHONENUMBERLabel.Name = "pHONENUMBERLabel";
            pHONENUMBERLabel.Size = new System.Drawing.Size(140, 23);
            pHONENUMBERLabel.TabIndex = 17;
            pHONENUMBERLabel.Text = "PHONENUMBER:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            eMAILLabel.Location = new System.Drawing.Point(629, 246);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(62, 23);
            eMAILLabel.TabIndex = 19;
            eMAILLabel.Text = "EMAIL:";
            // 
            // assignment3DatabaseDataSet
            // 
            this.assignment3DatabaseDataSet.DataSetName = "Assignment3DatabaseDataSet";
            this.assignment3DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignment3TableBindingSource
            // 
            this.assignment3TableBindingSource.DataMember = "Assignment3Table";
            this.assignment3TableBindingSource.DataSource = this.assignment3DatabaseDataSet;
            // 
            // assignment3TableTableAdapter
            // 
            this.assignment3TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Assignment3TableTableAdapter = this.assignment3TableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Assignment3.Assignment3DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fIRSTNAMETextBox
            // 
            this.fIRSTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "FIRSTNAME", true));
            this.fIRSTNAMETextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIRSTNAMETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fIRSTNAMETextBox.Location = new System.Drawing.Point(208, 50);
            this.fIRSTNAMETextBox.Name = "fIRSTNAMETextBox";
            this.fIRSTNAMETextBox.Size = new System.Drawing.Size(223, 30);
            this.fIRSTNAMETextBox.TabIndex = 2;
            // 
            // lASTNAMETextBox
            // 
            this.lASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "LASTNAME", true));
            this.lASTNAMETextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lASTNAMETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lASTNAMETextBox.Location = new System.Drawing.Point(208, 96);
            this.lASTNAMETextBox.Name = "lASTNAMETextBox";
            this.lASTNAMETextBox.Size = new System.Drawing.Size(223, 30);
            this.lASTNAMETextBox.TabIndex = 4;
            // 
            // sTREETNAMETextBox
            // 
            this.sTREETNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "STREETNAME", true));
            this.sTREETNAMETextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTREETNAMETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sTREETNAMETextBox.Location = new System.Drawing.Point(208, 148);
            this.sTREETNAMETextBox.Name = "sTREETNAMETextBox";
            this.sTREETNAMETextBox.Size = new System.Drawing.Size(223, 30);
            this.sTREETNAMETextBox.TabIndex = 6;
            // 
            // sTREETTextBox
            // 
            this.sTREETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "STREET", true));
            this.sTREETTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTREETTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sTREETTextBox.Location = new System.Drawing.Point(208, 196);
            this.sTREETTextBox.Name = "sTREETTextBox";
            this.sTREETTextBox.Size = new System.Drawing.Size(223, 30);
            this.sTREETTextBox.TabIndex = 8;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "CITY", true));
            this.cITYTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cITYTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cITYTextBox.Location = new System.Drawing.Point(208, 242);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(223, 30);
            this.cITYTextBox.TabIndex = 10;
            // 
            // pROVINCETextBox
            // 
            this.pROVINCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "PROVINCE", true));
            this.pROVINCETextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROVINCETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pROVINCETextBox.Location = new System.Drawing.Point(789, 49);
            this.pROVINCETextBox.Name = "pROVINCETextBox";
            this.pROVINCETextBox.Size = new System.Drawing.Size(224, 30);
            this.pROVINCETextBox.TabIndex = 12;
            // 
            // cOUNTRYTextBox
            // 
            this.cOUNTRYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "COUNTRY", true));
            this.cOUNTRYTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUNTRYTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cOUNTRYTextBox.Location = new System.Drawing.Point(789, 96);
            this.cOUNTRYTextBox.Name = "cOUNTRYTextBox";
            this.cOUNTRYTextBox.Size = new System.Drawing.Size(224, 30);
            this.cOUNTRYTextBox.TabIndex = 14;
            // 
            // pOSTALCODETextBox
            // 
            this.pOSTALCODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "POSTALCODE", true));
            this.pOSTALCODETextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSTALCODETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pOSTALCODETextBox.Location = new System.Drawing.Point(789, 148);
            this.pOSTALCODETextBox.Name = "pOSTALCODETextBox";
            this.pOSTALCODETextBox.Size = new System.Drawing.Size(224, 30);
            this.pOSTALCODETextBox.TabIndex = 16;
            // 
            // pHONENUMBERTextBox
            // 
            this.pHONENUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "PHONENUMBER", true));
            this.pHONENUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHONENUMBERTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pHONENUMBERTextBox.Location = new System.Drawing.Point(789, 196);
            this.pHONENUMBERTextBox.Name = "pHONENUMBERTextBox";
            this.pHONENUMBERTextBox.Size = new System.Drawing.Size(224, 30);
            this.pHONENUMBERTextBox.TabIndex = 18;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment3TableBindingSource, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAILTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eMAILTextBox.Location = new System.Drawing.Point(789, 245);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(224, 30);
            this.eMAILTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(334, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Primary Key:";
            // 
            // errorsTxtBox
            // 
            this.errorsTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsTxtBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.errorsTxtBox.Location = new System.Drawing.Point(460, 352);
            this.errorsTxtBox.Name = "errorsTxtBox";
            this.errorsTxtBox.ReadOnly = true;
            this.errorsTxtBox.Size = new System.Drawing.Size(321, 31);
            this.errorsTxtBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(376, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Status:";
            // 
            // primaryKeyTxtBox
            // 
            this.primaryKeyTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryKeyTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.primaryKeyTxtBox.Location = new System.Drawing.Point(460, 303);
            this.primaryKeyTxtBox.Name = "primaryKeyTxtBox";
            this.primaryKeyTxtBox.ReadOnly = true;
            this.primaryKeyTxtBox.Size = new System.Drawing.Size(207, 31);
            this.primaryKeyTxtBox.TabIndex = 24;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NextButton.FlatAppearance.BorderSize = 2;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextButton.Location = new System.Drawing.Point(549, 527);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(91, 35);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.previousButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.previousButton.FlatAppearance.BorderSize = 2;
            this.previousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.previousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.previousButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousButton.Location = new System.Drawing.Point(414, 527);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(91, 35);
            this.previousButton.TabIndex = 26;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentRecTxtBox
            // 
            this.currentRecTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRecTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.currentRecTxtBox.Location = new System.Drawing.Point(237, 475);
            this.currentRecTxtBox.Name = "currentRecTxtBox";
            this.currentRecTxtBox.ReadOnly = true;
            this.currentRecTxtBox.Size = new System.Drawing.Size(72, 31);
            this.currentRecTxtBox.TabIndex = 30;
            // 
            // totalRecords
            // 
            this.totalRecords.AutoSize = true;
            this.totalRecords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalRecords.Location = new System.Drawing.Point(94, 524);
            this.totalRecords.Name = "totalRecords";
            this.totalRecords.Size = new System.Drawing.Size(127, 25);
            this.totalRecords.TabIndex = 29;
            this.totalRecords.Text = "Total Records:";
            // 
            // totalRecTxtBox
            // 
            this.totalRecTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecTxtBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalRecTxtBox.Location = new System.Drawing.Point(237, 524);
            this.totalRecTxtBox.Name = "totalRecTxtBox";
            this.totalRecTxtBox.ReadOnly = true;
            this.totalRecTxtBox.Size = new System.Drawing.Size(72, 31);
            this.totalRecTxtBox.TabIndex = 28;
            // 
            // currentRecords
            // 
            this.currentRecords.AutoSize = true;
            this.currentRecords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.currentRecords.Location = new System.Drawing.Point(94, 478);
            this.currentRecords.Name = "currentRecords";
            this.currentRecords.Size = new System.Drawing.Size(139, 25);
            this.currentRecords.TabIndex = 27;
            this.currentRecords.Text = "Current Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 574);
            this.Controls.Add(this.currentRecTxtBox);
            this.Controls.Add(this.totalRecords);
            this.Controls.Add(this.totalRecTxtBox);
            this.Controls.Add(this.currentRecords);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.primaryKeyTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorsTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(fIRSTNAMELabel);
            this.Controls.Add(this.fIRSTNAMETextBox);
            this.Controls.Add(lASTNAMELabel);
            this.Controls.Add(this.lASTNAMETextBox);
            this.Controls.Add(sTREETNAMELabel);
            this.Controls.Add(this.sTREETNAMETextBox);
            this.Controls.Add(sTREETLabel);
            this.Controls.Add(this.sTREETTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(pROVINCELabel);
            this.Controls.Add(this.pROVINCETextBox);
            this.Controls.Add(cOUNTRYLabel);
            this.Controls.Add(this.cOUNTRYTextBox);
            this.Controls.Add(pOSTALCODELabel);
            this.Controls.Add(this.pOSTALCODETextBox);
            this.Controls.Add(pHONENUMBERLabel);
            this.Controls.Add(this.pHONENUMBERTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignment3DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment3TableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Assignment3DatabaseDataSet assignment3DatabaseDataSet;
        private System.Windows.Forms.BindingSource assignment3TableBindingSource;
        private Assignment3DatabaseDataSetTableAdapters.Assignment3TableTableAdapter assignment3TableTableAdapter;
        private Assignment3DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fIRSTNAMETextBox;
        private System.Windows.Forms.TextBox lASTNAMETextBox;
        private System.Windows.Forms.TextBox sTREETNAMETextBox;
        private System.Windows.Forms.TextBox sTREETTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.TextBox pROVINCETextBox;
        private System.Windows.Forms.TextBox cOUNTRYTextBox;
        private System.Windows.Forms.TextBox pOSTALCODETextBox;
        private System.Windows.Forms.TextBox pHONENUMBERTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorsTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primaryKeyTxtBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox currentRecTxtBox;
        private System.Windows.Forms.Label totalRecords;
        private System.Windows.Forms.TextBox totalRecTxtBox;
        private System.Windows.Forms.Label currentRecords;
    }
}

