import java.util.Comparator;
import java.util.TreeSet;

public class Manager {
    private String phoneNumber;
    private TreeSet<WorkGroup> workGroupTreeSet;
    private static Comparator<WorkGroup> workGroupComparator = Comparator.comparing(WorkGroup::getSpecialization);

    public Manager(String phoneNumber) throws Exception {
        setPhoneNumber(phoneNumber);
        workGroupTreeSet = new TreeSet<>(workGroupComparator);
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) throws Exception {
        if (phoneNumber != null)
            this.phoneNumber = phoneNumber;
        else
            throw new Exception("Phone number cannot be null!");
    }
    public void addWorkGroup(WorkGroup workGroup)
    {
        workGroupTreeSet.add(workGroup);
    }

    public TreeSet<WorkGroup> getWorkGroupTreeSet() {
        return workGroupTreeSet;
    }
}
