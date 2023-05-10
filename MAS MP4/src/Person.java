import java.time.LocalDate;
import java.util.*;

public class Person {
    private String name;
    private LocalDate birthdate;
    private String pesel;
    public static Map<String, Person> peselMap = new HashMap<>();

    public Person(String name, LocalDate birthdate, String pesel) throws Exception {
        this.name = name;
        this.birthdate = birthdate;
        setPesel(pesel);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public LocalDate getBirthdate() {
        return birthdate;
    }

    public void setBirthdate(LocalDate birthdate) {
        this.birthdate = birthdate;
    }

    public String getPesel() {
        return pesel;
    }

    public void setPesel(String pesel) throws Exception {
        if (peselMap.containsKey(pesel)) throw new Exception("This pesel is already registered");
        else {
            peselMap.put(pesel,this);
            this.pesel = pesel;
        }
    }

    @Override
    public String  toString() {
        return "Osoba{" +
                "name='" + name + '\'' +
                ", birthdate=" + birthdate +
                ", pesel='" + pesel + '\'' +
                '}';
    }
}
