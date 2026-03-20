namespace WinFormsApp1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblNumberOfItems = new System.Windows.Forms.Label();
        txtNumberOfItems = new System.Windows.Forms.TextBox();
        lblCapacity = new System.Windows.Forms.Label();
        txtCapacity = new System.Windows.Forms.TextBox();
        lblSeed = new System.Windows.Forms.Label();
        txtSeed = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        txtData = new System.Windows.Forms.TextBox();
        txtResults = new System.Windows.Forms.TextBox();
        lblData = new System.Windows.Forms.Label();
        lblResults = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lblNumberOfItems
        // 
        lblNumberOfItems.AutoSize = true;
        lblNumberOfItems.Location = new System.Drawing.Point(40, 25);
        lblNumberOfItems.Name = "lblNumberOfItems";
        lblNumberOfItems.Size = new System.Drawing.Size(121, 20);
        lblNumberOfItems.TabIndex = 0;
        lblNumberOfItems.Text = "Number of items";
        // 
        // txtNumberOfItems
        // 
        txtNumberOfItems.Location = new System.Drawing.Point(40, 48);
        txtNumberOfItems.Name = "txtNumberOfItems";
        txtNumberOfItems.Size = new System.Drawing.Size(180, 27);
        txtNumberOfItems.TabIndex = 1;
        // 
        // lblCapacity
        // 
        lblCapacity.AutoSize = true;
        lblCapacity.Location = new System.Drawing.Point(40, 88);
        lblCapacity.Name = "lblCapacity";
        lblCapacity.Size = new System.Drawing.Size(66, 20);
        lblCapacity.TabIndex = 2;
        lblCapacity.Text = "Capacity";
        // 
        // txtCapacity
        // 
        txtCapacity.Location = new System.Drawing.Point(40, 111);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Size = new System.Drawing.Size(180, 27);
        txtCapacity.TabIndex = 3;
        // 
        // lblSeed
        // 
        lblSeed.AutoSize = true;
        lblSeed.Location = new System.Drawing.Point(40, 151);
        lblSeed.Name = "lblSeed";
        lblSeed.Size = new System.Drawing.Size(42, 20);
        lblSeed.TabIndex = 4;
        lblSeed.Text = "Seed";
        // 
        // txtSeed
        // 
        txtSeed.Location = new System.Drawing.Point(40, 174);
        txtSeed.Name = "txtSeed";
        txtSeed.Size = new System.Drawing.Size(180, 27);
        txtSeed.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(145, 242);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 36);
        button1.TabIndex = 6;
        button1.Text = "run";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // txtData
        // 
        txtData.Location = new System.Drawing.Point(302, 48);
        txtData.Multiline = true;
        txtData.Name = "txtData";
        txtData.ReadOnly = true;
        txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtData.Size = new System.Drawing.Size(367, 212);
        txtData.TabIndex = 7;
        // 
        // txtResults
        // 
        txtResults.Location = new System.Drawing.Point(302, 289);
        txtResults.Multiline = true;
        txtResults.Name = "txtResults";
        txtResults.ReadOnly = true;
        txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtResults.Size = new System.Drawing.Size(367, 290);
        txtResults.TabIndex = 8;
        // 
        // lblData
        // 
        lblData.Location = new System.Drawing.Point(302, 25);
        lblData.Name = "lblData";
        lblData.Size = new System.Drawing.Size(229, 23);
        lblData.TabIndex = 9;
        lblData.Text = "Data";
        // 
        // lblResults
        // 
        lblResults.Location = new System.Drawing.Point(302, 263);
        lblResults.Name = "lblResults";
        lblResults.Size = new System.Drawing.Size(229, 23);
        lblResults.TabIndex = 10;
        lblResults.Text = "Results";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(681, 591);
        Controls.Add(lblResults);
        Controls.Add(lblData);
        Controls.Add(txtResults);
        Controls.Add(txtData);
        Controls.Add(button1);
        Controls.Add(txtSeed);
        Controls.Add(lblSeed);
        Controls.Add(txtCapacity);
        Controls.Add(lblCapacity);
        Controls.Add(txtNumberOfItems);
        Controls.Add(lblNumberOfItems);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblResults;

    private System.Windows.Forms.Label lblData;

    private System.Windows.Forms.TextBox txtResults;

    private System.Windows.Forms.TextBox txtData;

    private System.Windows.Forms.Button button1;

    #endregion

    private Label lblNumberOfItems;
    private TextBox txtNumberOfItems;
    private Label lblCapacity;
    private TextBox txtCapacity;
    private Label lblSeed;
    private TextBox txtSeed;
}