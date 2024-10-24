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
        childLabel = new Label();
        SuspendLayout();
        // 
        // childLabel
        // 
        childLabel.BorderStyle = BorderStyle.FixedSingle;
        childLabel.Location = new Point(86, 77);
        childLabel.Name = "childLabel";
        childLabel.Size = new Size(310, 38);
        childLabel.TabIndex = 0;
        childLabel.Text = "label1";
        // 
        // ChildForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 223);
        Controls.Add(childLabel);
        Name = "ChildForm";
        Text = "Child Form";
        Load += ChildForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Label childLabel;
}