namespace WinFormsClassDemo;

partial class ChildForm
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
        nameLabel = new Label();
        ageLabel = new Label();
        adultCheckBox = new CheckBox();
        seniorCheckBox = new CheckBox();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.BorderStyle = BorderStyle.FixedSingle;
        nameLabel.Location = new Point(86, 77);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(310, 29);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "label1";
        // 
        // ageLabel
        // 
        ageLabel.BorderStyle = BorderStyle.FixedSingle;
        ageLabel.Location = new Point(86, 141);
        ageLabel.Name = "ageLabel";
        ageLabel.Size = new Size(310, 29);
        ageLabel.TabIndex = 1;
        ageLabel.Text = "label1";
        // 
        // adultCheckBox
        // 
        adultCheckBox.AutoSize = true;
        adultCheckBox.Enabled = false;
        adultCheckBox.Location = new Point(86, 208);
        adultCheckBox.Name = "adultCheckBox";
        adultCheckBox.Size = new Size(81, 24);
        adultCheckBox.TabIndex = 2;
        adultCheckBox.Text = "Is Adult";
        adultCheckBox.UseVisualStyleBackColor = true;
        // 
        // seniorCheckBox
        // 
        seniorCheckBox.AutoSize = true;
        seniorCheckBox.Enabled = false;
        seniorCheckBox.Location = new Point(260, 208);
        seniorCheckBox.Name = "seniorCheckBox";
        seniorCheckBox.Size = new Size(136, 24);
        seniorCheckBox.TabIndex = 3;
        seniorCheckBox.Text = "Is Senior Citizen";
        seniorCheckBox.UseVisualStyleBackColor = true;
        // 
        // ChildForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 337);
        Controls.Add(seniorCheckBox);
        Controls.Add(adultCheckBox);
        Controls.Add(ageLabel);
        Controls.Add(nameLabel);
        Name = "ChildForm";
        Text = "Child Form";
        Load += ChildForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private Label ageLabel;
    private CheckBox adultCheckBox;
    private CheckBox seniorCheckBox;
}