namespace UWOsh_InteractiveMap;

public partial class Compass : ContentPage
{
	public Compass()
	{
		InitializeComponent();
	}
	
	/*Distance function
	 * 
	      c  /|  b
	        / |
	        ---
	        a
	 c = Location.CalculateDistance(UserLocation , PlantLocation)
	 b = Location.CalculateDistance(PlantLocation x UserLocation y   , PlantLocation)
	 a = Location.CalculateDistance(UserLocation , PlantLocation x  UserLocation y)

	A = arccos((b*b + c*c - a*a) / (2bc)) opposite angle of side a
	Location boston = new Location(42.358056, -71.063611);
	Location sanFrancisco = new Location(37.783333, -122.416667);

	double miles = Location.CalculateDistance(boston, sanFrancisco, DistanceUnits.Miles);
	 */
}
