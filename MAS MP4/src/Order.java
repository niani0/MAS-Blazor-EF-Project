import java.util.ArrayList;
import java.util.List;

public class Order {
    private String orderId;
    private List<SupervisorOrder> supervisorOrderList;

    public Order(String orderId) {
        this.orderId = orderId;
        this.supervisorOrderList = new ArrayList<>();
    }

    public String getOrderId() {
        return orderId;
    }

    public void setOrderId(String orderId) {
        this.orderId = orderId;
    }

    public void addSupervisorToOrder(SupervisorOrder supervisorOrder) {
        if (supervisorOrder != null && supervisorOrder.getOrder() == this)
            supervisorOrderList.add(supervisorOrder);
    }

    @Override
    public String toString() {
        return "Order{" +
                "orderId='" + orderId + '\'' +
                '}';
    }
}
