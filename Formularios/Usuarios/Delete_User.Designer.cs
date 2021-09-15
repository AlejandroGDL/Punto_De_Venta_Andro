
namespace Punto_De_Venta_Andro.Formularios.Usuarios
{
    partial class Delete_User
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
            this.PanelTittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDUserEliminate = new System.Windows.Forms.Label();
            this.BtnCancelEliminate = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminate = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserEliminate = new System.Windows.Forms.Label();
            this.txtNameEliminate = new System.Windows.Forms.Label();
            this.PBEliminate = new System.Windows.Forms.PictureBox();
            this.DragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragForm1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtRolEliminate = new System.Windows.Forms.Label();
            this.PanelTittle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBEliminate)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTittle
            // 
            this.PanelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.PanelTittle.Controls.Add(this.label1);
            this.PanelTittle.Location = new System.Drawing.Point(0, 0);
            this.PanelTittle.Name = "PanelTittle";
            this.PanelTittle.Size = new System.Drawing.Size(750, 47);
            this.PanelTittle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Realmente deseas eliminar este usuario?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtRolEliminate);
            this.panel1.Controls.Add(this.IDUserEliminate);
            this.panel1.Controls.Add(this.BtnCancelEliminate);
            this.panel1.Controls.Add(this.BtnEliminate);
            this.panel1.Controls.Add(this.txtUserEliminate);
            this.panel1.Controls.Add(this.txtNameEliminate);
            this.panel1.Controls.Add(this.PBEliminate);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 203);
            this.panel1.TabIndex = 2;
            // 
            // IDUserEliminate
            // 
            this.IDUserEliminate.AutoSize = true;
            this.IDUserEliminate.Location = new System.Drawing.Point(214, 127);
            this.IDUserEliminate.Name = "IDUserEliminate";
            this.IDUserEliminate.Size = new System.Drawing.Size(37, 13);
            this.IDUserEliminate.TabIndex = 5;
            this.IDUserEliminate.Text = "84124";
            this.IDUserEliminate.Visible = false;
            // 
            // BtnCancelEliminate
            // 
            this.BtnCancelEliminate.AutoRoundedCorners = true;
            this.BtnCancelEliminate.BorderRadius = 21;
            this.BtnCancelEliminate.CheckedState.Parent = this.BtnCancelEliminate;
            this.BtnCancelEliminate.CustomImages.Parent = this.BtnCancelEliminate;
            this.BtnCancelEliminate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelEliminate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelEliminate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancelEliminate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancelEliminate.DisabledState.Parent = this.BtnCancelEliminate;
            this.BtnCancelEliminate.FillColor = System.Drawing.Color.White;
            this.BtnCancelEliminate.Font = new System.Drawing.Font("Quicksand", 15F);
            this.BtnCancelEliminate.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelEliminate.HoverState.Parent = this.BtnCancelEliminate;
            this.BtnCancelEliminate.Location = new System.Drawing.Point(555, 148);
            this.BtnCancelEliminate.Name = "BtnCancelEliminate";
            this.BtnCancelEliminate.ShadowDecoration.Parent = this.BtnCancelEliminate;
            this.BtnCancelEliminate.Size = new System.Drawing.Size(180, 45);
            this.BtnCancelEliminate.TabIndex = 4;
            this.BtnCancelEliminate.Text = "Cancelar";
            this.BtnCancelEliminate.Click += new System.EventHandler(this.BtnCancelEliminate_Click);
            // 
            // BtnEliminate
            // 
            this.BtnEliminate.AutoRoundedCorners = true;
            this.BtnEliminate.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEliminate.BorderRadius = 21;
            this.BtnEliminate.CheckedState.Parent = this.BtnEliminate;
            this.BtnEliminate.CustomImages.Parent = this.BtnEliminate;
            this.BtnEliminate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEliminate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEliminate.DisabledState.Parent = this.BtnEliminate;
            this.BtnEliminate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.BtnEliminate.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminate.ForeColor = System.Drawing.Color.White;
            this.BtnEliminate.HoverState.Parent = this.BtnEliminate;
            this.BtnEliminate.Location = new System.Drawing.Point(369, 148);
            this.BtnEliminate.Name = "BtnEliminate";
            this.BtnEliminate.ShadowDecoration.Parent = this.BtnEliminate;
            this.BtnEliminate.Size = new System.Drawing.Size(180, 45);
            this.BtnEliminate.TabIndex = 3;
            this.BtnEliminate.Text = "Eliminar";
            this.BtnEliminate.Click += new System.EventHandler(this.BtnEliminate_Click);
            // 
            // txtUserEliminate
            // 
            this.txtUserEliminate.AutoSize = true;
            this.txtUserEliminate.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEliminate.Location = new System.Drawing.Point(212, 47);
            this.txtUserEliminate.Name = "txtUserEliminate";
            this.txtUserEliminate.Size = new System.Drawing.Size(140, 30);
            this.txtUserEliminate.TabIndex = 2;
            this.txtUserEliminate.Text = "Usuario Largo";
            // 
            // txtNameEliminate
            // 
            this.txtNameEliminate.AutoSize = true;
            this.txtNameEliminate.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEliminate.Location = new System.Drawing.Point(212, 8);
            this.txtNameEliminate.Name = "txtNameEliminate";
            this.txtNameEliminate.Size = new System.Drawing.Size(211, 30);
            this.txtNameEliminate.TabIndex = 1;
            this.txtNameEliminate.Text = "Un Nombre Completo";
            // 
            // PBEliminate
            // 
            this.PBEliminate.Location = new System.Drawing.Point(9, 8);
            this.PBEliminate.Name = "PBEliminate";
            this.PBEliminate.Size = new System.Drawing.Size(185, 185);
            this.PBEliminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBEliminate.TabIndex = 0;
            this.PBEliminate.TabStop = false;
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this.label1;
            // 
            // DragForm1
            // 
            this.DragForm1.TargetControl = this.panel1;
            // 
            // txtRolEliminate
            // 
            this.txtRolEliminate.AutoSize = true;
            this.txtRolEliminate.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolEliminate.Location = new System.Drawing.Point(212, 86);
            this.txtRolEliminate.Name = "txtRolEliminate";
            this.txtRolEliminate.Size = new System.Drawing.Size(100, 30);
            this.txtRolEliminate.TabIndex = 6;
            this.txtRolEliminate.Text = "Rol Largo";
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(750, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_User";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_User";
            this.TopMost = true;
            this.PanelTittle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBEliminate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnEliminate;
        private Guna.UI2.WinForms.Guna2Button BtnCancelEliminate;
        public System.Windows.Forms.Label txtUserEliminate;
        public System.Windows.Forms.Label txtNameEliminate;
        public System.Windows.Forms.Label IDUserEliminate;
        public System.Windows.Forms.PictureBox PBEliminate;
        private Guna.UI2.WinForms.Guna2DragControl DragForm;
        private Guna.UI2.WinForms.Guna2DragControl DragForm1;
        public System.Windows.Forms.Label txtRolEliminate;
    }
}