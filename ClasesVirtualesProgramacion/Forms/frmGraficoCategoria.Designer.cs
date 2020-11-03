namespace ClasesVirtualesProgramacion.Forms
{
    partial class frmGraficoCategoria
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.oGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dsClasesVirtuales = new ClasesVirtualesProgramacion.Data.dsClasesVirtuales();
            this.totalporcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.oGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.oGrafico.Legends.Add(legend2);
            this.oGrafico.Location = new System.Drawing.Point(26, 15);
            this.oGrafico.Name = "oGrafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.oGrafico.Series.Add(series2);
            this.oGrafico.Size = new System.Drawing.Size(1040, 494);
            this.oGrafico.TabIndex = 0;
            this.oGrafico.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Gráfico Por Categoría";
            this.oGrafico.Titles.Add(title2);
            // 
            // dsClasesVirtuales
            // 
            this.dsClasesVirtuales.DataSetName = "dsClasesVirtuales";
            this.dsClasesVirtuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalporcategoriaBindingSource
            // 
            this.totalporcategoriaBindingSource.DataMember = "Totalporcategoria";
            this.totalporcategoriaBindingSource.DataSource = this.dsClasesVirtuales;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(654, 524);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 51);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(829, 523);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(144, 51);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGraficoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(1094, 603);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.oGrafico);
            this.Name = "frmGraficoCategoria";
            this.Text = "frmGraficoCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.oGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalporcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart oGrafico;
        private Data.dsClasesVirtuales dsClasesVirtuales;
        private System.Windows.Forms.BindingSource totalporcategoriaBindingSource;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}