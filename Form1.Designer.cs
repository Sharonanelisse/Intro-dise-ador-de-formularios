namespace PruebaWin_Form
{
    partial class FormularioContacto
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
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMensaje = new TextBox();
            EtiquetaNombre = new Label();
            EtiquetaEmail = new Label();
            EtiquetaMensaje = new Label();
            ButtonEnviar = new Button();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Cursor = Cursors.IBeam;
            TextBoxNombre.Location = new Point(162, 44);
            TextBoxNombre.Margin = new Padding(2, 1, 2, 1);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(259, 23);
            TextBoxNombre.TabIndex = 0;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Cursor = Cursors.IBeam;
            TextBoxEmail.Location = new Point(162, 92);
            TextBoxEmail.Margin = new Padding(2, 1, 2, 1);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(259, 23);
            TextBoxEmail.TabIndex = 1;
            // 
            // TextBoxMensaje
            // 
            TextBoxMensaje.Cursor = Cursors.IBeam;
            TextBoxMensaje.Location = new Point(162, 138);
            TextBoxMensaje.Margin = new Padding(2, 1, 2, 1);
            TextBoxMensaje.Multiline = true;
            TextBoxMensaje.Name = "TextBoxMensaje";
            TextBoxMensaje.ScrollBars = ScrollBars.Vertical;
            TextBoxMensaje.Size = new Size(259, 117);
            TextBoxMensaje.TabIndex = 2;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(29, 45);
            EtiquetaNombre.Margin = new Padding(2, 0, 2, 0);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(54, 15);
            EtiquetaNombre.TabIndex = 3;
            EtiquetaNombre.Text = "Nombre:";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(29, 94);
            EtiquetaEmail.Margin = new Padding(2, 0, 2, 0);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(108, 15);
            EtiquetaEmail.TabIndex = 4;
            EtiquetaEmail.Text = "Correo Electrónico:";
            // 
            // EtiquetaMensaje
            // 
            EtiquetaMensaje.AutoSize = true;
            EtiquetaMensaje.Location = new Point(29, 142);
            EtiquetaMensaje.Margin = new Padding(2, 0, 2, 0);
            EtiquetaMensaje.Name = "EtiquetaMensaje";
            EtiquetaMensaje.Size = new Size(54, 15);
            EtiquetaMensaje.TabIndex = 5;
            EtiquetaMensaje.Text = "Mensaje:";
            EtiquetaMensaje.Click += label2_Click;
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.Location = new Point(239, 280);
            ButtonEnviar.Margin = new Padding(2, 1, 2, 1);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(95, 40);
            ButtonEnviar.TabIndex = 6;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = true;
            ButtonEnviar.Click += ButtonEnviar_Click;
            // 
            // LabelEstado
            // 
            LabelEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelEstado.AutoSize = true;
            LabelEstado.BackColor = SystemColors.ActiveCaption;
            LabelEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(12, 280);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 17);
            LabelEstado.TabIndex = 7;
            // 
            // FormularioContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(460, 330);
            Controls.Add(LabelEstado);
            Controls.Add(ButtonEnviar);
            Controls.Add(EtiquetaMensaje);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaNombre);
            Controls.Add(TextBoxMensaje);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormularioContacto";
            Text = "FormularioContacto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxMensaje;
        private Label EtiquetaNombre;
        private Label EtiquetaEmail;
        private Label EtiquetaMensaje;
        private Button ButtonEnviar;
        private Label LabelEstado;
    }
}
