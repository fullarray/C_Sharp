public interface IPeople{
	string getName();
}

public class CountryPeople : IPeople{
	public string getName(){
		return "Country guy";
	}
}

public class CityPeople : IPeople{
	public string getName(){
		return "City guy";
	}
}

public enum PeopleType{
	RURAL,URBAN;
}

public class FactoryPattern{
	public IPeople getPeople(PeopleType type){
		IPeople people = null;
		
		switch(type){
			case PeopleType.RURAL:
				people = new CountryPeople();
				break;
			case PeopleType.URBAN:
				people = new CityPeople();
				break;
			default:
				break;
		}
		return people;
	}
}
