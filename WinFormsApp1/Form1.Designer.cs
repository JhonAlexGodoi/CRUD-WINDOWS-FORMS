namespace WinFormsApp1
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
            btnCrear = new Button();
            cmbBlog = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCuerpo = new RichTextBox();
            txtTitulo = new TextBox();
            dgvPost = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPost).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(342, 26);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Guardar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbBlog
            // 
            cmbBlog.FormattingEnabled = true;
            cmbBlog.Location = new Point(12, 197);
            cmbBlog.Name = "cmbBlog";
            cmbBlog.Size = new Size(263, 23);
            cmbBlog.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Cuerpo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Blog";
            // 
            // txtCuerpo
            // 
            txtCuerpo.Location = new Point(12, 80);
            txtCuerpo.Name = "txtCuerpo";
            txtCuerpo.Size = new Size(263, 96);
            txtCuerpo.TabIndex = 5;
            txtCuerpo.Text = "";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(263, 23);
            txtTitulo.TabIndex = 6;
            // 
            // dgvPost
            // 
            dgvPost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPost.Location = new Point(12, 226);
            dgvPost.Name = "dgvPost";
            dgvPost.Size = new Size(405, 108);
            dgvPost.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 346);
            Controls.Add(dgvPost);
            Controls.Add(txtTitulo);
            Controls.Add(txtCuerpo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBlog);
            Controls.Add(btnCrear);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Editor de POST";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private ComboBox cmbBlog;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox txtCuerpo;
        private TextBox txtTitulo;
        private DataGridView dgvPost;
    }
}
