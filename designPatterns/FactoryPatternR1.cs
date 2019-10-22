public interface IPeople{
	string getName();
}

public class CountryPeople: IPeople{
	public string getName(){
		return "Country man";
	}
}
public class CityPeople: IPeople{
	public string getName(){
		return "City man";
	}
}
public enum PeopleType{
	COUNTRY, CITY
}
public class FactoryPatternR1{
	public IPeople getPeople(PeopleType type){
		IPeople person = null;
		switch(type){
			case PeopleType.COUNTRY:
				people = new CountryPeople();
				break;
			case PeopleType.CITY:
				people = new CityPeople();
				break;
			default:
				break;
		}
		return people;
	}
}
