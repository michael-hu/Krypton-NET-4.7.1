﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Storage for color button string properties.
	/// </summary>
    public class PaletteColorButtonStrings : Storage
    {
        #region Static Fields

        private const string DEFAULT_MORE_COLORS = "&More Colors...";
        private const string DEFAULT_NO_COLOR = "&No Color";
        private const string DEFAULT_RECENT_COLORS = "Recent Colors";
        private const string DEFAULT_STANDARD_COLORS = "Standard Colors";
        private const string DEFAULT_THEME_COLORS = "Theme Colors";

        #endregion

        #region Instance Fields
        private string _moreColors;
        private string _noColor;
        private string _recentColors;
        private string _standardColors;
        private string _themeColors;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteColorButtonStrings class.
		/// </summary>
        public PaletteColorButtonStrings()
		{
            // Default values
            _moreColors = DEFAULT_MORE_COLORS;
            _noColor = DEFAULT_NO_COLOR;
            _recentColors = DEFAULT_RECENT_COLORS;
            _standardColors = DEFAULT_STANDARD_COLORS;
            _themeColors = DEFAULT_THEME_COLORS;
        }
		#endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return (MoreColors.Equals(DEFAULT_MORE_COLORS)) &&
                       (NoColor.Equals(DEFAULT_NO_COLOR)) &&
                       (RecentColors.Equals(DEFAULT_RECENT_COLORS)) &&
                       (StandardColors.Equals(DEFAULT_STANDARD_COLORS)) &&
                       (ThemeColors.Equals(DEFAULT_THEME_COLORS));
            }
        }
        #endregion

        #region MoreColors
        /// <summary>
        /// Gets and sets the menu string for a 'more colors' entry.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for a 'more colors' entry.")]
        [DefaultValue("&More Colors...")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string MoreColors
        {
            get { return _moreColors; }
            set { _moreColors = value; }
        }
        #endregion

        #region NoColor
        /// <summary>
        /// Gets and sets the menu string for a 'no color' entry.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for a 'no color' entry.")]
        [DefaultValue("&No Color")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string NoColor
        {
            get { return _noColor; }
            set { _noColor = value; }
        }
        #endregion

        #region RecentColors
        /// <summary>
        /// Gets and sets the title for the recent colors section of the color button menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for recent colors section of the color button menu.")]
        [DefaultValue("Recent Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string RecentColors
        {
            get { return _recentColors; }
            set { _recentColors = value; }
        }
        #endregion

        #region StandardColors
        /// <summary>
        /// Gets and sets the title for the standard colors section of the application menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for standard colors section of the color button menu.")]
        [DefaultValue("Standard Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string StandardColors
        {
            get { return _standardColors; }
            set { _standardColors = value; }
        }
        #endregion

        #region ThemeColors
        /// <summary>
        /// Gets and sets the title for the theme colors section of the application menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for theme colors section of the color button menu.")]
        [DefaultValue("Theme Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ThemeColors
        {
            get { return _themeColors; }
            set { _themeColors = value; }
        }
        #endregion
    }
}
