using System;

/// <summary>
/// Material Fantasy themed Custom Message Box - .NET 4.8 Compatible
/// Maintains original logic while providing modern Material Design with fantasy aesthetic
/// </summary>
public static class CustomMessageBox
{
    public delegate DialogResult ShowDelegate(string text, string caption = "",
        MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None,
        string YesText = "Yes", string NoText = "No");

    public static event ShowDelegate ShowEvent;

    /// <summary>Show message box with just text</summary>
    public static DialogResult Show(string text)
    {
        return Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.None);
    }

    /// <summary>Show message box with text and caption</summary>
    public static DialogResult Show(string text, string caption)
    {
        return Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
    }

    /// <summary>Show message box with full parameters</summary>
    public static int Show(string text, string caption = "", object MessageBoxButtons = null,
        object MessageBoxIcon = null)
    {
        if (MessageBoxButtons == null)
            MessageBoxButtons = CustomMessageBox.MessageBoxButtons.OK;
        if (MessageBoxIcon == null)
            MessageBoxIcon = CustomMessageBox.MessageBoxIcon.None;

        return (int)Show(text, caption, (MessageBoxButtons)(int)MessageBoxButtons, (MessageBoxIcon)(int)MessageBoxIcon);
    }

    /// <summary>Show message box with all customization options</summary>
    public static DialogResult Show(string text, string caption = "",
        MessageBoxButtons MessageBoxButtons = MessageBoxButtons.OK,
        MessageBoxIcon MessageBoxIcon = MessageBoxIcon.None,
        string YesText = "Yes", string NoText = "No")
    {
        Console.WriteLine("CustomMessageBox.Show");

        if (ShowEvent != null)
            return ShowEvent.Invoke(text, caption, MessageBoxButtons, MessageBoxIcon, YesText, NoText);

        throw new Exception("ShowEvent Not Set");
    }

    // =====================================================================
    // MATERIAL FANTASY COLOR SCHEME (as hex strings for .NET 4.8)
    // =====================================================================

    /// <summary>Material Fantasy Primary Color - Deep Purple (#6739B7)</summary>
    public static string PrimaryColorHex => "#6739B7";

    /// <summary>Material Fantasy Secondary Color - Indigo (#3F51B5)</summary>
    public static string SecondaryColorHex => "#3F51B5";

    /// <summary>Material Fantasy Success Color - Green (#4CAF50)</summary>
    public static string SuccessColorHex => "#4CAF50";

    /// <summary>Material Fantasy Warning Color - Amber (#FF9800)</summary>
    public static string WarningColorHex => "#FF9800";

    /// <summary>Material Fantasy Error Color - Red (#F44336)</summary>
    public static string ErrorColorHex => "#F44336";

    /// <summary>Material Fantasy Info Color - Blue (#2196F3)</summary>
    public static string InfoColorHex => "#2196F3";

    /// <summary>Material Fantasy Background Dark (#212121)</summary>
    public static string BackgroundDarkHex => "#212121";

    /// <summary>Material Fantasy Background Light (#FAFAFA)</summary>
    public static string BackgroundLightHex => "#FAFAFA";

    /// <summary>Get color hex based on icon type for Material Fantasy theme</summary>
    public static string GetIconColorHex(MessageBoxIcon icon)
    {
        switch (icon)
        {
            //case MessageBoxIcon.Hand:
            //case MessageBoxIcon.Stop:
            case MessageBoxIcon.Error:
                return ErrorColorHex;
            //case MessageBoxIcon.Exclamation:
            case MessageBoxIcon.Warning:
                return WarningColorHex;
            //case MessageBoxIcon.Asterisk:
            case MessageBoxIcon.Information:
                return InfoColorHex;
            case MessageBoxIcon.Question:
                return SecondaryColorHex;
            default:
                return PrimaryColorHex;
        }
    }

    /// <summary>Get icon symbol for Material Fantasy theme using Unicode symbols</summary>
    public static string GetIconSymbol(MessageBoxIcon icon)
    {
        switch (icon)
        {
            //case MessageBoxIcon.Hand:
            //    break;
            //case MessageBoxIcon.Stop:
            //    break;
            case MessageBoxIcon.Error:
                return "✕"; // Error X
            //case MessageBoxIcon.Exclamation:
            case MessageBoxIcon.Warning:
                return "⚠"; // Warning
            //case MessageBoxIcon.Asterisk:
            case MessageBoxIcon.Information:
                return "ℹ"; // Info
            case MessageBoxIcon.Question:
                return "?"; // Question
            default:
                return "";
        }
    }

    public enum DialogResult
    {
        /// <summary>Nothing is returned from the dialog box. This means that the modal dialog continues running.</summary>
        None,
        /// <summary>The dialog box return value is OK (usually sent from a button labeled OK).</summary>
        OK,
        /// <summary>The dialog box return value is Cancel (usually sent from a button labeled Cancel).</summary>
        Cancel,
        /// <summary>The dialog box return value is Abort (usually sent from a button labeled Abort).</summary>
        Abort,
        /// <summary>The dialog box return value is Retry (usually sent from a button labeled Retry).</summary>
        Retry,
        /// <summary>The dialog box return value is Ignore (usually sent from a button labeled Ignore).</summary>
        Ignore,
        /// <summary>The dialog box return value is Yes (usually sent from a button labeled Yes).</summary>
        Yes,
        /// <summary>The dialog box return value is No (usually sent from a button labeled No).</summary>
        No
    }

    public enum MessageBoxButtons
    {
        /// <summary>The message box contains an OK button.</summary>
        OK,
        /// <summary>The message box contains OK and Cancel buttons.</summary>
        OKCancel,
        /// <summary>The message box contains Abort, Retry, and Ignore buttons.</summary>
        AbortRetryIgnore,
        /// <summary>The message box contains Yes, No, and Cancel buttons.</summary>
        YesNoCancel,
        /// <summary>The message box contains Yes and No buttons.</summary>
        YesNo,
        /// <summary>The message box contains Retry and Cancel buttons.</summary>
        RetryCancel
    }

    public enum MessageBoxIcon
    {
        /// <summary>The message box contain no symbols.</summary>
        None,
        /// <summary>The message box contains a symbol consisting of a white X in a circle with a red background.</summary>
        Hand = 16,
        /// <summary>The message box contains a symbol consisting of a question mark in a circle.</summary>
        Question = 32,
        /// <summary>The message box contains a symbol consisting of an exclamation point in a triangle with a yellow background.</summary>
        Exclamation = 48,
        /// <summary>The message box contains a symbol consisting of a lowercase letter i in a circle.</summary>
        Asterisk = 64,
        /// <summary>The message box contains a symbol consisting of white X in a circle with a red background.</summary>
        Stop = 16,
        /// <summary>The message box contains a symbol consisting of white X in a circle with a red background.</summary>
        Error = 16,
        /// <summary>The message box contains a symbol consisting of an exclamation point in a triangle with a yellow background.</summary>
        Warning = 48,
        /// <summary>The message box contains a symbol consisting of a lowercase letter i in a circle.</summary>
        Information = 64
    }
}