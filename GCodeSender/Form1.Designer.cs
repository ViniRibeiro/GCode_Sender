namespace GCodeSender
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
            this.FechaForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtMinimiza = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListaHistorico = new System.Windows.Forms.ListView();
            this.NumeroLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodesLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextEnvio = new System.Windows.Forms.TextBox();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.LbNumEnvio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaForm
            // 
            this.FechaForm.FlatAppearance.BorderSize = 0;
            this.FechaForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FechaForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FechaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaForm.ForeColor = System.Drawing.Color.White;
            this.FechaForm.Location = new System.Drawing.Point(232, 0);
            this.FechaForm.Name = "FechaForm";
            this.FechaForm.Size = new System.Drawing.Size(25, 20);
            this.FechaForm.TabIndex = 0;
            this.FechaForm.Text = "X";
            this.FechaForm.UseVisualStyleBackColor = true;
            this.FechaForm.Click += new System.EventHandler(this.FechaForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "GCodeSender";
            // 
            // BtMinimiza
            // 
            this.BtMinimiza.FlatAppearance.BorderSize = 0;
            this.BtMinimiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtMinimiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMinimiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMinimiza.ForeColor = System.Drawing.Color.White;
            this.BtMinimiza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtMinimiza.Location = new System.Drawing.Point(204, -3);
            this.BtMinimiza.Margin = new System.Windows.Forms.Padding(0);
            this.BtMinimiza.Name = "BtMinimiza";
            this.BtMinimiza.Size = new System.Drawing.Size(25, 22);
            this.BtMinimiza.TabIndex = 2;
            this.BtMinimiza.Text = "-";
            this.BtMinimiza.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtMinimiza.UseVisualStyleBackColor = true;
            this.BtMinimiza.Click += new System.EventHandler(this.BtMinimiza_Click);
            // 
            // ListaHistorico
            // 
            this.ListaHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaHistorico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeroLista,
            this.CodesLista,
            this.StatusLista});
            this.ListaHistorico.ForeColor = System.Drawing.Color.White;
            this.ListaHistorico.GridLines = true;
            this.ListaHistorico.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListaHistorico.HideSelection = false;
            this.ListaHistorico.Location = new System.Drawing.Point(5, 129);
            this.ListaHistorico.MultiSelect = false;
            this.ListaHistorico.Name = "ListaHistorico";
            this.ListaHistorico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListaHistorico.Size = new System.Drawing.Size(252, 230);
            this.ListaHistorico.TabIndex = 7;
            this.ListaHistorico.UseCompatibleStateImageBehavior = false;
            this.ListaHistorico.View = System.Windows.Forms.View.Details;
            // 
            // NumeroLista
            // 
            this.NumeroLista.Text = "Nº";
            this.NumeroLista.Width = 32;
            // 
            // CodesLista
            // 
            this.CodesLista.Text = "Comando";
            this.CodesLista.Width = 160;
            // 
            // StatusLista
            // 
            this.StatusLista.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(5, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 93);
            this.panel2.TabIndex = 8;
            // 
            // TextEnvio
            // 
            this.TextEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEnvio.ForeColor = System.Drawing.Color.White;
            this.TextEnvio.Location = new System.Drawing.Point(37, 365);
            this.TextEnvio.Multiline = true;
            this.TextEnvio.Name = "TextEnvio";
            this.TextEnvio.Size = new System.Drawing.Size(161, 22);
            this.TextEnvio.TabIndex = 9;
            // 
            // BtEnviar
            // 
            this.BtEnviar.BackColor = System.Drawing.Color.Cyan;
            this.BtEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtEnviar.FlatAppearance.BorderSize = 0;
            this.BtEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviar.Location = new System.Drawing.Point(195, 365);
            this.BtEnviar.Margin = new System.Windows.Forms.Padding(0);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(62, 22);
            this.BtEnviar.TabIndex = 10;
            this.BtEnviar.Text = "Enviar";
            this.BtEnviar.UseVisualStyleBackColor = false;
            this.BtEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // LbNumEnvio
            // 
            this.LbNumEnvio.ForeColor = System.Drawing.Color.White;
            this.LbNumEnvio.Location = new System.Drawing.Point(10, 365);
            this.LbNumEnvio.Name = "LbNumEnvio";
            this.LbNumEnvio.Size = new System.Drawing.Size(36, 22);
            this.LbNumEnvio.TabIndex = 11;
            this.LbNumEnvio.Text = "0.";
            this.LbNumEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(263, 400);
            this.Controls.Add(this.TextEnvio);
            this.Controls.Add(this.LbNumEnvio);
            this.Controls.Add(this.BtEnviar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ListaHistorico);
            this.Controls.Add(this.BtMinimiza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FechaForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtMinimiza;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView ListaHistorico;
        private System.Windows.Forms.ColumnHeader NumeroLista;
        private System.Windows.Forms.ColumnHeader CodesLista;
        private System.Windows.Forms.ColumnHeader StatusLista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextEnvio;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.Label LbNumEnvio;
    }
}

