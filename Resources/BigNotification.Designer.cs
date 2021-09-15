
namespace Punto_De_Venta_Andro.Resources
{
    partial class BigNotification
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
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.FormBorder = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtNotification = new System.Windows.Forms.Label();
            this.PExclamation = new System.Windows.Forms.Panel();
            this.PBNotificacion = new System.Windows.Forms.PictureBox();
            this.PAdvice = new System.Windows.Forms.Panel();
            this.LblAdvice = new System.Windows.Forms.Label();
            this.PNotification = new System.Windows.Forms.Panel();
            this.ArrastrarForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PExclamation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBNotificacion)).BeginInit();
            this.PAdvice.SuspendLayout();
            this.PNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerClose
            // 
            this.TimerClose.Interval = 3000;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // FormBorder
            // 
            this.FormBorder.BorderRadius = 10;
            this.FormBorder.TargetControl = this;
            // 
            // txtNotification
            // 
            this.txtNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNotification.Font = new System.Drawing.Font("Quicksand", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotification.ForeColor = System.Drawing.Color.Black;
            this.txtNotification.Location = new System.Drawing.Point(0, 0);
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(870, 150);
            this.txtNotification.TabIndex = 0;
            this.txtNotification.Text = "Error";
            this.txtNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PExclamation
            // 
            this.PExclamation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PExclamation.Controls.Add(this.PBNotificacion);
            this.PExclamation.Dock = System.Windows.Forms.DockStyle.Left;
            this.PExclamation.Location = new System.Drawing.Point(0, 0);
            this.PExclamation.Name = "PExclamation";
            this.PExclamation.Size = new System.Drawing.Size(200, 200);
            this.PExclamation.TabIndex = 1;
            // 
            // PBNotificacion
            // 
            this.PBNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBNotificacion.BackColor = System.Drawing.Color.Transparent;
            this.PBNotificacion.Image = global::Punto_De_Venta_Andro.Properties.Resources.Exclamation;
            this.PBNotificacion.ImageLocation = "";
            this.PBNotificacion.Location = new System.Drawing.Point(31, 32);
            this.PBNotificacion.Name = "PBNotificacion";
            this.PBNotificacion.Size = new System.Drawing.Size(125, 125);
            this.PBNotificacion.TabIndex = 0;
            this.PBNotificacion.TabStop = false;
            // 
            // PAdvice
            // 
            this.PAdvice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PAdvice.Controls.Add(this.LblAdvice);
            this.PAdvice.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAdvice.Location = new System.Drawing.Point(200, 0);
            this.PAdvice.Name = "PAdvice";
            this.PAdvice.Size = new System.Drawing.Size(870, 50);
            this.PAdvice.TabIndex = 2;
            // 
            // LblAdvice
            // 
            this.LblAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAdvice.BackColor = System.Drawing.Color.Transparent;
            this.LblAdvice.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdvice.ForeColor = System.Drawing.Color.White;
            this.LblAdvice.Location = new System.Drawing.Point(0, -10);
            this.LblAdvice.Name = "LblAdvice";
            this.LblAdvice.Size = new System.Drawing.Size(870, 60);
            this.LblAdvice.TabIndex = 0;
            this.LblAdvice.Text = "Advertencia!";
            this.LblAdvice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PNotification
            // 
            this.PNotification.Controls.Add(this.txtNotification);
            this.PNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNotification.Location = new System.Drawing.Point(200, 50);
            this.PNotification.Name = "PNotification";
            this.PNotification.Size = new System.Drawing.Size(870, 150);
            this.PNotification.TabIndex = 3;
            // 
            // ArrastrarForm
            // 
            this.ArrastrarForm.TargetControl = this.txtNotification;
            // 
            // BigNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 200);
            this.Controls.Add(this.PNotification);
            this.Controls.Add(this.PAdvice);
            this.Controls.Add(this.PExclamation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BigNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BigNotification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BigNotification_Load);
            this.PExclamation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBNotificacion)).EndInit();
            this.PAdvice.ResumeLayout(false);
            this.PNotification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerClose;
        private Guna.UI2.WinForms.Guna2Elipse FormBorder;
        public System.Windows.Forms.Label txtNotification;
        private System.Windows.Forms.Panel PNotification;
        public System.Windows.Forms.PictureBox PBNotificacion;
        public System.Windows.Forms.Panel PExclamation;
        public System.Windows.Forms.Label LblAdvice;
        public System.Windows.Forms.Panel PAdvice;
        private Guna.UI2.WinForms.Guna2DragControl ArrastrarForm;
    }
}