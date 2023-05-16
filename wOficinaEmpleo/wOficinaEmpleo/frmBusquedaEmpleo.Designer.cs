namespace wOficinaEmpleo
{
    partial class frmBusquedaEmpleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaEmpleo));
            this.dtgEmpleos = new System.Windows.Forms.DataGridView();
            this.txtIntIdEmpleo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmpleos
            // 
            this.dtgEmpleos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleos.Location = new System.Drawing.Point(96, 210);
            this.dtgEmpleos.Name = "dtgEmpleos";
            this.dtgEmpleos.RowHeadersWidth = 51;
            this.dtgEmpleos.RowTemplate.Height = 24;
            this.dtgEmpleos.Size = new System.Drawing.Size(911, 317);
            this.dtgEmpleos.TabIndex = 0;
            // 
            // txtIntIdEmpleo
            // 
            this.txtIntIdEmpleo.Location = new System.Drawing.Point(398, 109);
            this.txtIntIdEmpleo.Name = "txtIntIdEmpleo";
            this.txtIntIdEmpleo.Size = new System.Drawing.Size(81, 22);
            this.txtIntIdEmpleo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBusquedaEmpleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 539);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntIdEmpleo);
            this.Controls.Add(this.dtgEmpleos);
            this.Name = "frmBusquedaEmpleo";
            this.Text = "frmBusquedaEmpleo";
            this.Load += new System.EventHandler(this.frmBusquedaEmpleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmpleos;
        private System.Windows.Forms.TextBox txtIntIdEmpleo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
    }
}