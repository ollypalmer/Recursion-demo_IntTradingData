namespace InternationalTradingData
{
    partial class editForm
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
            this.CountryLable = new System.Windows.Forms.Label();
            this.GdpLabel = new System.Windows.Forms.Label();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.TradeBalLabel = new System.Windows.Forms.Label();
            this.HdiLabel = new System.Windows.Forms.Label();
            this.TradePartLabel = new System.Windows.Forms.Label();
            this.countrytb = new System.Windows.Forms.TextBox();
            this.gdptb = new System.Windows.Forms.TextBox();
            this.inflationtb = new System.Windows.Forms.TextBox();
            this.tradeBaltb = new System.Windows.Forms.TextBox();
            this.hditb = new System.Windows.Forms.TextBox();
            this.saveButt = new System.Windows.Forms.Button();
            this.cancelButt = new System.Windows.Forms.Button();
            this.tradePartlv = new System.Windows.Forms.ListView();
            this.partnerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CountryLable
            // 
            this.CountryLable.AutoSize = true;
            this.CountryLable.Location = new System.Drawing.Point(36, 37);
            this.CountryLable.Name = "CountryLable";
            this.CountryLable.Size = new System.Drawing.Size(43, 13);
            this.CountryLable.TabIndex = 0;
            this.CountryLable.Text = "Country";
            // 
            // GdpLabel
            // 
            this.GdpLabel.AutoSize = true;
            this.GdpLabel.Location = new System.Drawing.Point(12, 100);
            this.GdpLabel.Name = "GdpLabel";
            this.GdpLabel.Size = new System.Drawing.Size(67, 13);
            this.GdpLabel.TabIndex = 1;
            this.GdpLabel.Text = "GDP Growth";
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(36, 158);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(44, 13);
            this.InflationLabel.TabIndex = 2;
            this.InflationLabel.Text = "Inflation";
            // 
            // TradeBalLabel
            // 
            this.TradeBalLabel.AutoSize = true;
            this.TradeBalLabel.Location = new System.Drawing.Point(205, 40);
            this.TradeBalLabel.Name = "TradeBalLabel";
            this.TradeBalLabel.Size = new System.Drawing.Size(77, 13);
            this.TradeBalLabel.TabIndex = 3;
            this.TradeBalLabel.Text = "Trade Balance";
            // 
            // HdiLabel
            // 
            this.HdiLabel.AutoSize = true;
            this.HdiLabel.Location = new System.Drawing.Point(227, 100);
            this.HdiLabel.Name = "HdiLabel";
            this.HdiLabel.Size = new System.Drawing.Size(55, 13);
            this.HdiLabel.TabIndex = 4;
            this.HdiLabel.Text = "HDI Rank";
            // 
            // TradePartLabel
            // 
            this.TradePartLabel.AutoSize = true;
            this.TradePartLabel.Location = new System.Drawing.Point(205, 158);
            this.TradePartLabel.Name = "TradePartLabel";
            this.TradePartLabel.Size = new System.Drawing.Size(77, 13);
            this.TradePartLabel.TabIndex = 5;
            this.TradePartLabel.Text = "Trade Partners";
            // 
            // countrytb
            // 
            this.countrytb.Location = new System.Drawing.Point(85, 37);
            this.countrytb.Name = "countrytb";
            this.countrytb.Size = new System.Drawing.Size(100, 20);
            this.countrytb.TabIndex = 6;
            // 
            // gdptb
            // 
            this.gdptb.Location = new System.Drawing.Point(85, 97);
            this.gdptb.Name = "gdptb";
            this.gdptb.Size = new System.Drawing.Size(100, 20);
            this.gdptb.TabIndex = 7;
            this.gdptb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gdptb_KeyPress);
            // 
            // inflationtb
            // 
            this.inflationtb.Location = new System.Drawing.Point(86, 158);
            this.inflationtb.Name = "inflationtb";
            this.inflationtb.Size = new System.Drawing.Size(100, 20);
            this.inflationtb.TabIndex = 8;
            this.inflationtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inflationtb_KeyPress);
            // 
            // tradeBaltb
            // 
            this.tradeBaltb.Location = new System.Drawing.Point(288, 37);
            this.tradeBaltb.Name = "tradeBaltb";
            this.tradeBaltb.Size = new System.Drawing.Size(100, 20);
            this.tradeBaltb.TabIndex = 9;
            this.tradeBaltb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tradeBaltb_KeyPress);
            // 
            // hditb
            // 
            this.hditb.Location = new System.Drawing.Point(288, 97);
            this.hditb.Name = "hditb";
            this.hditb.Size = new System.Drawing.Size(100, 20);
            this.hditb.TabIndex = 10;
            this.hditb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hditb_KeyPress);
            // 
            // saveButt
            // 
            this.saveButt.Location = new System.Drawing.Point(15, 207);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 23);
            this.saveButt.TabIndex = 12;
            this.saveButt.Text = "Save";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // cancelButt
            // 
            this.cancelButt.Location = new System.Drawing.Point(110, 207);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(75, 23);
            this.cancelButt.TabIndex = 13;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.UseVisualStyleBackColor = true;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // tradePartlv
            // 
            this.tradePartlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partnerName});
            this.tradePartlv.LabelEdit = true;
            this.tradePartlv.Location = new System.Drawing.Point(288, 158);
            this.tradePartlv.Name = "tradePartlv";
            this.tradePartlv.Size = new System.Drawing.Size(100, 72);
            this.tradePartlv.TabIndex = 15;
            this.tradePartlv.UseCompatibleStateImageBehavior = false;
            this.tradePartlv.View = System.Windows.Forms.View.Details;
            // 
            // partnerName
            // 
            this.partnerName.Text = "";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 248);
            this.Controls.Add(this.tradePartlv);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.hditb);
            this.Controls.Add(this.tradeBaltb);
            this.Controls.Add(this.inflationtb);
            this.Controls.Add(this.gdptb);
            this.Controls.Add(this.countrytb);
            this.Controls.Add(this.TradePartLabel);
            this.Controls.Add(this.HdiLabel);
            this.Controls.Add(this.TradeBalLabel);
            this.Controls.Add(this.InflationLabel);
            this.Controls.Add(this.GdpLabel);
            this.Controls.Add(this.CountryLable);
            this.Name = "editForm";
            this.Text = "Edit Country";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountryLable;
        private System.Windows.Forms.Label GdpLabel;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.Label TradeBalLabel;
        private System.Windows.Forms.Label HdiLabel;
        private System.Windows.Forms.Label TradePartLabel;
        private System.Windows.Forms.TextBox countrytb;
        private System.Windows.Forms.TextBox gdptb;
        private System.Windows.Forms.TextBox inflationtb;
        private System.Windows.Forms.TextBox tradeBaltb;
        private System.Windows.Forms.TextBox hditb;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.ListView tradePartlv;
        private System.Windows.Forms.ColumnHeader partnerName;
    }
}