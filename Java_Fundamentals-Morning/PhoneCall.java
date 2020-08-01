interface Phone
{
    public void call(Integer number);  // Functin to call given number
    public void recieve();
    public void pickUp();
    public void RingStatus();
    public void end();
}

interface Connectioncheck{
    public boolean ConnectStatus();
    public boolean isPickedUp();

}

class PhoneCall implements Phone,Connectioncheck
{
    public boolean ConnectStatus;
    public boolean PickedUp;

    public PhoneCall() {
        ConnectStatus = false;
        PickedUp = false;
    }
    @Override
    public void call(Integer number) {
        System.out.println("Calling... "+number);
    }
    @Override
    public void recieve() {
        RingStatus();
        pickUp();
        ConnectStatus= true;
        System.out.println("Received by the other party");
    }
    @Override
public void pickUp() {

    PickedUp = true;
    System.out.println("picking up to call");
}
    @Override
    public void RingStatus() {
        System.out.println("Phone Ringing....");

    }
    @Override
    public void end() {
        PickedUp = false;
        ConnectStatus = false;
        System.out.println("Call Ended");
    }
    @Override
    public boolean ConnectStatus() {
        return ConnectStatus;
    }
    @Override
    public boolean isPickedUp() {
        return PickedUp;
    }
}

class UsePhone {
    public static void main(String[] args) {

        PhoneCall p = new PhoneCall();
        p.pickUp();
        p.call(987654321);
        p.recieve();
        p.end();
    }
}