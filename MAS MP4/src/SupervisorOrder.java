import java.time.LocalDate;

public class SupervisorOrder {
    private LocalDate date;
    private Order order;
    private Supervisor supervisor;

    public SupervisorOrder(LocalDate date, Order order, Supervisor supervisor) {
        this.date = date;
        this.order = order;
        this.supervisor = supervisor;

        order.addSupervisorToOrder(this);
        supervisor.addSupervisorToOrder(this);
    }

    public LocalDate getDate() {
        return date;
    }

    public Order getOrder() {
        return order;
    }

    public Supervisor getSupervisor() {
        return supervisor;
    }

    @Override
    public String toString() {
        return "SupervisorOrder{" +
                "date=" + date +
                ", order=" + order +
                ", supervisor=" + supervisor +
                '}';
    }
}
