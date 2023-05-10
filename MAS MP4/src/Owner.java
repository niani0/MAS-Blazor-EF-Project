import utils.ObjectPlus4;

public class Owner extends ObjectPlus4 {
    String email;
    public static final String isOwning = "is owning";
    public static final String has = "has";

    public Owner(String email) {
        this.email = email;
    }
}
