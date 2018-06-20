namespace UI.Console
{
    partial class frmTarea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.Consultar = new System.Windows.Forms.TabControl();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 1;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-5, 60);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(808, 40);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DodgerBlue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-5, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(811, 101);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.Agregar);
            this.Consultar.Controls.Add(this.tabPage2);
            this.Consultar.Location = new System.Drawing.Point(-3, 108);
            this.Consultar.Name = "Consultar";
            this.Consultar.SelectedIndex = 0;
            this.Consultar.Size = new System.Drawing.Size(806, 340);
            this.Consultar.TabIndex = 2;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.Agregar.Size = new System.Drawing.Size(798, 314);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.panel1);
            this.Name = "frmTarea";
            this.Text = "Tarea";
            this.panel1.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TabControl Consultar;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.TabPage tabPage2;
    }
}