namespace progettoCassa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxRiepilogo = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonScontrino = new Button();
            buttonAggiungi = new Button();
            buttonRimuovi = new Button();
            textBoxOggetto = new TextBox();
            textBoxPrezzo = new TextBox();
            textBoxQuantita = new TextBox();
            labelImportoCassa = new Label();
            SuspendLayout();
            // 
            // listBoxRiepilogo
            // 
            listBoxRiepilogo.BackColor = SystemColors.InactiveCaption;
            listBoxRiepilogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxRiepilogo.FormattingEnabled = true;
            listBoxRiepilogo.ItemHeight = 41;
            listBoxRiepilogo.Location = new Point(529, 61);
            listBoxRiepilogo.Name = "listBoxRiepilogo";
            listBoxRiepilogo.Size = new Size(475, 332);
            listBoxRiepilogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(529, 17);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 1;
            label1.Text = "Riepilogo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(66, 61);
            label2.Name = "label2";
            label2.Size = new Size(294, 41);
            label2.TabIndex = 2;
            label2.Text = "Descrizione oggetto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(66, 172);
            label3.Name = "label3";
            label3.Size = new Size(148, 41);
            label3.TabIndex = 3;
            label3.Text = "Prezzo(€):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(295, 172);
            label4.Name = "label4";
            label4.Size = new Size(139, 41);
            label4.TabIndex = 4;
            label4.Text = "Quantità:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(68, 509);
            label5.Name = "label5";
            label5.Size = new Size(366, 41);
            label5.TabIndex = 5;
            label5.Text = "Importo dovuto alla cassa:";
            // 
            // buttonScontrino
            // 
            buttonScontrino.BackColor = Color.FromArgb(128, 255, 128);
            buttonScontrino.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonScontrino.Location = new Point(586, 509);
            buttonScontrino.Name = "buttonScontrino";
            buttonScontrino.Size = new Size(356, 101);
            buttonScontrino.TabIndex = 6;
            buttonScontrino.Text = "💾​ emetti scontrino";
            buttonScontrino.UseVisualStyleBackColor = false;
            buttonScontrino.Click += buttonScontrino_Click;
            // 
            // buttonAggiungi
            // 
            buttonAggiungi.BackColor = Color.FromArgb(128, 255, 255);
            buttonAggiungi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAggiungi.Location = new Point(66, 288);
            buttonAggiungi.Name = "buttonAggiungi";
            buttonAggiungi.Size = new Size(368, 53);
            buttonAggiungi.TabIndex = 7;
            buttonAggiungi.Text = "+ aggiungi voce";
            buttonAggiungi.UseVisualStyleBackColor = false;
            buttonAggiungi.Click += buttonAggiungi_Click;
            // 
            // buttonRimuovi
            // 
            buttonRimuovi.BackColor = Color.Silver;
            buttonRimuovi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRimuovi.Location = new Point(66, 372);
            buttonRimuovi.Name = "buttonRimuovi";
            buttonRimuovi.Size = new Size(368, 53);
            buttonRimuovi.TabIndex = 8;
            buttonRimuovi.Text = "Rimuovi selezionato";
            buttonRimuovi.UseVisualStyleBackColor = false;
            buttonRimuovi.Click += buttonRimuovi_Click;
            // 
            // textBoxOggetto
            // 
            textBoxOggetto.Location = new Point(66, 117);
            textBoxOggetto.Name = "textBoxOggetto";
            textBoxOggetto.Size = new Size(294, 27);
            textBoxOggetto.TabIndex = 9;
            // 
            // textBoxPrezzo
            // 
            textBoxPrezzo.Location = new Point(66, 230);
            textBoxPrezzo.Name = "textBoxPrezzo";
            textBoxPrezzo.Size = new Size(148, 27);
            textBoxPrezzo.TabIndex = 10;
            // 
            // textBoxQuantita
            // 
            textBoxQuantita.Location = new Point(295, 230);
            textBoxQuantita.Name = "textBoxQuantita";
            textBoxQuantita.Size = new Size(148, 27);
            textBoxQuantita.TabIndex = 11;
            // 
            // labelImportoCassa
            // 
            labelImportoCassa.AutoSize = true;
            labelImportoCassa.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelImportoCassa.ForeColor = SystemColors.Control;
            labelImportoCassa.Location = new Point(68, 556);
            labelImportoCassa.Name = "labelImportoCassa";
            labelImportoCassa.Size = new Size(45, 54);
            labelImportoCassa.TabIndex = 12;
            labelImportoCassa.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1042, 707);
            Controls.Add(labelImportoCassa);
            Controls.Add(textBoxQuantita);
            Controls.Add(textBoxPrezzo);
            Controls.Add(textBoxOggetto);
            Controls.Add(buttonRimuovi);
            Controls.Add(buttonAggiungi);
            Controls.Add(buttonScontrino);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxRiepilogo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRiepilogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonScontrino;
        private Button buttonAggiungi;
        private Button buttonRimuovi;
        private TextBox textBoxOggetto;
        private TextBox textBoxPrezzo;
        private TextBox textBoxQuantita;
        private Label labelImportoCassa;
    }
}
