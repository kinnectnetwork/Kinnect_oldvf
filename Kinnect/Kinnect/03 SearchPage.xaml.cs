using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kinnect
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
        private double ScalingFactor;

        public SearchPage ()
		{
			InitializeComponent ();
            ScalingFactor = (float)256 / 375;
            GridProfile.ColumnDefinitions[0].Width = new GridLength(20 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[1].Width = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[2].Width = new GridLength(10 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[3].Width = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[4].Width = new GridLength(10 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[5].Width = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[6].Width = new GridLength(10 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[7].Width = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[8].Width = new GridLength(10 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[9].Width = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            GridProfile.ColumnDefinitions[10].Width = new GridLength(20 * ScalingFactor, GridUnitType.Absolute);

        }
    }
}