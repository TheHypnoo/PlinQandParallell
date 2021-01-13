namespace PlinQandParallell
{
    partial class PlinQandParallell
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlinQandParallell));
            this.btSequencial = new System.Windows.Forms.Button();
            this.btParallel = new System.Windows.Forms.Button();
            this.listJson = new System.Windows.Forms.ListView();
            this.Formulario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeS = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listJson2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btSequencial
            // 
            this.btSequencial.Location = new System.Drawing.Point(112, 12);
            this.btSequencial.Name = "btSequencial";
            this.btSequencial.Size = new System.Drawing.Size(75, 23);
            this.btSequencial.TabIndex = 1;
            this.btSequencial.Text = "Sequencial";
            this.btSequencial.UseVisualStyleBackColor = true;
            this.btSequencial.Click += new System.EventHandler(this.btSequencial_Click);
            // 
            // btParallel
            // 
            this.btParallel.Location = new System.Drawing.Point(532, 12);
            this.btParallel.Name = "btParallel";
            this.btParallel.Size = new System.Drawing.Size(75, 23);
            this.btParallel.TabIndex = 2;
            this.btParallel.Text = "Parallel";
            this.btParallel.UseVisualStyleBackColor = true;
            this.btParallel.Click += new System.EventHandler(this.btParallel_Click);
            // 
            // listJson
            // 
            this.listJson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Formulario,
            this.Email,
            this.DNI});
            this.listJson.HideSelection = false;
            this.listJson.Location = new System.Drawing.Point(12, 47);
            this.listJson.Name = "listJson";
            this.listJson.Size = new System.Drawing.Size(330, 270);
            this.listJson.TabIndex = 3;
            this.listJson.UseCompatibleStateImageBehavior = false;
            this.listJson.View = System.Windows.Forms.View.Details;
            // 
            // Formulario
            // 
            this.Formulario.Name = "Formulario";
            this.Formulario.Text = "Name";
            this.Formulario.Width = 68;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 165;
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.Width = 75;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(330, 336);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // timeS
            // 
            this.timeS.Location = new System.Drawing.Point(88, 338);
            this.timeS.Name = "timeS";
            this.timeS.Size = new System.Drawing.Size(125, 20);
            this.timeS.TabIndex = 6;
            // 
            // listJson2
            // 
            this.listJson2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listJson2.HideSelection = false;
            this.listJson2.Location = new System.Drawing.Point(400, 47);
            this.listJson2.Name = "listJson2";
            this.listJson2.Size = new System.Drawing.Size(330, 270);
            this.listJson2.TabIndex = 7;
            this.listJson2.UseCompatibleStateImageBehavior = false;
            this.listJson2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DNI";
            this.columnHeader3.Width = 75;
            // 
            // timeP
            // 
            this.timeP.Location = new System.Drawing.Point(532, 339);
            this.timeP.Name = "timeP";
            this.timeP.Size = new System.Drawing.Size(125, 20);
            this.timeP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(677, 367);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by TheHypnoo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PlinQandParallell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(753, 383);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeP);
            this.Controls.Add(this.listJson2);
            this.Controls.Add(this.timeS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.listJson);
            this.Controls.Add(this.btParallel);
            this.Controls.Add(this.btSequencial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlinQandParallell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequencial&Parallel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSequencial;
        private System.Windows.Forms.Button btParallel;
        private System.Windows.Forms.ListView listJson;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listJson2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Formulario;
        private System.Windows.Forms.TextBox timeP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

