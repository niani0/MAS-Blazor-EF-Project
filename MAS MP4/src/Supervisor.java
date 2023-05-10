import java.util.ArrayList;
import java.util.List;

public class Supervisor {
    private String name;
    private int salary;
    private List<SupervisorOrder> supervisorOrderList;

    public Supervisor(String name, int salary) {
        this.name = name;
        this.salary = salary;

        this.supervisorOrderList = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public int getSalary() {
        return salary;
    }

    public void addSupervisorToOrder(SupervisorOrder supervisorOrder) {
        if (supervisorOrder != null && supervisorOrder.getSupervisor() == this)
            supervisorOrderList.add(supervisorOrder);
    }

    @Override
    public String toString() {
        return "Supervisor{" +
                "name='" + name + '\'' +
                ", salary=" + salary +
                '}';
    }
}
