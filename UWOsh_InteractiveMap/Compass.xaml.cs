//using Android.Locations;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Gauges;
//using static Android.Views.WindowInsets;
//using static Android.Provider.ContactsContract.CommonDataKinds;
using Location = Microsoft.Maui.Devices.Sensors.Location;

namespace UWOsh_InteractiveMap;
/*
Author: Benjamin Wastart
Reviewer: 
*/
public partial class Compass : ContentPage
{
    private Location NORTH = new Location(81.3, 110.8); //Magnetic North
    private ShapePointer pointer = new ShapePointer();
    private RadialAxis radialAxis = new RadialAxis();
	private Location myLocation = new Location();
	private LocationFeaturescs featurescs = new LocationFeaturescs();
	private Location pointb; //The third point in the triangle

    public Compass()
{
	InitializeComponent();
        SetCompass();
        SetPointer();
        SetGuide(NORTH);
		
    }

    public Compass(Location plant)
    {
        InitializeComponent();
        SetCompass();
        SetPointer();
        SetGuide(plant);
    }

		public void SetGuide()
	{
        SetGuide(NORTH);
        //myLocation = featurescs.myLocation;
        //compassGauge.Axes.Add(radialAxis);


        //double sidec = Location.CalculateDistance(myLocation, NORTH, DistanceUnits.Miles);
        //pointb = new Location(myLocation.Latitude, NORTH.Longitude);

        //double sideb = Location.CalculateDistance(pointb, NORTH, DistanceUnits.Miles);

        //double sidea = Location.CalculateDistance(myLocation, pointb, DistanceUnits.Miles);

        //pointer.Value = (320 + (Math.Acos(((sidea * sidea + sidec * sidec - sideb * sideb) / (2 * sidea * sidec)))) * 180 / Math.PI) % 360;

        //radialAxis.Pointers.Add(pointer);
    }

        public void SetGuide(Location plant)
	{
        myLocation = featurescs.myLocation;
        compassGauge.Axes.Add(radialAxis);


        double sidec = Location.CalculateDistance(myLocation, plant, DistanceUnits.Miles);
        pointb = new Location(myLocation.Latitude, plant.Longitude);

        double sideb = Location.CalculateDistance(pointb, plant, DistanceUnits.Miles);

        double sidea = Location.CalculateDistance(myLocation, pointb, DistanceUnits.Miles);

        pointer.Value = (320 + (Math.Acos(((sidea * sidea + sidec * sidec - sideb * sideb) / (2 * sidea * sidec)))) * 180 / Math.PI) % 360;
                
        radialAxis.Pointers.Add(pointer);
    }

    private void SetCompass()
    {
        radialAxis.Pointers.Clear();
        radialAxis.ShowAxisLine= false;
        radialAxis.TickPosition = GaugeElementPosition.Outside;
        radialAxis.LabelPosition = GaugeLabelsPosition.Outside;
        radialAxis.StartAngle= 320;
        radialAxis.EndAngle = 320;
        radialAxis.RadiusFactor = 0.6;
        radialAxis.MinorTicksPerInterval = 10;
        radialAxis.Minimum = 0;
        radialAxis.Maximum = 360;
        radialAxis.ShowLastLabel = false;
        radialAxis.Interval = 30;
        radialAxis.OffsetUnit = SizeUnit.Factor;
    }

    private void SetPointer()
    {
        pointer.ShapeHeight = 40;
        pointer.ShapeWidth = 40;
        pointer.ShapeType = ShapeType.Triangle;
        pointer.Stroke = Color.Parse("Black");
        pointer.Fill = Color.Parse("Blue");
        pointer.Offset = 18;
    }
}

    /*<!--<gauge:ShapePointer Value="90"
		ShapeType="Triangle" 
		ShapeHeight="40"
		ShapeWidth="40"
		Stroke="Black"
		Fill="Blue"
		Offset="18"/> --><!--offset from outside circle-->
     * The Location constructor accepts the latitude and longitude arguments, respectively. 
     * Positive latitude values are north of the equator, and positive longitude values are east of the Prime Meridian. 
     * Use the final argument to CalculateDistance to specify miles or kilometers. 
     * The UnitConverters class also defines KilometersToMiles and MilesToKilometers methods for converting between the two units.
	 * Distance function
	 * 
	      c  /|  b
	        / |
	        ---
	        a
	 c = Location.CalculateDistance(UserLocation , PlantLocation)
	 b = Location.CalculateDistance(PlantLocation x UserLocation y   , PlantLocation)
	 a = Location.CalculateDistance(UserLocation , PlantLocation x  UserLocation y)

	A = arccos((b*b + c*c - a*a) / (2bc)) opposite angle of side a
	B = arccos((a*a + c*c - b*b) / (2ac)) opposite angle of side b
	Location self = new Location(42.358056, -71.063611); lat, log
	Location plant = new Location(37.783333, -122.416667); y, x - n, w

	double clength = Location.CalculateDistance(self, plant, DistanceUnits.Kilometers);
	north = 81.3 N 110.8 W
	Math.Acos() is the cos-1 function in .NET
	 c = Location.CalculateDistance(UserLocation , north)
	 b = Location.CalculateDistance( UserLocation.N 110.8  , north)
	 a = Location.CalculateDistance(UserLocation ,  UserLocation.n 110.8)
	
	 */

