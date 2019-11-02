import java.util.Date;

/**
 * A HotelBooking is a LocationBooking with a fixed total price, a number of
 * booked single rooms, and a number of booked double rooms.
 *
 * @author Marcel Zacharias
 */
public class HotelBooking extends LocationBooking implements HasFixedPrice {

    /** total price in pence for the booking rooms */
    private int totalPriceInPence;

    /** number of single rooms */
    private int singleRooms;

    /** number of double rooms */
    private int doubleRooms;

    /**
     * Constructs a new HotelBooking according to the parameters.
     * Note that at least one room must be booked.
     *
     * @param name the name for which the booking was made; must not be null
     * @param date the point in time for which the booking was made; must not be null
     *  and must not be in the past
     * @param location the address of the hotel; must not be null
     * @param totalPriceInPence the total price in pence for the booking
     * @param singleRooms the number of single rooms, must be at least 0
     * @param doubleRooms the number of double rooms, must be at least 0 
     */
    public HotelBooking(String name, Date date, String location, int totalPriceInPence, int singleRooms, int doubleRooms) {
        super(name, date, location);
        this.totalPriceInPence = totalPriceInPence;
        if(singleRooms < 0){
            throw new IllegalArgumentException("Expected at least 0 singleRooms, found: " + singleRooms);
        }
        if(doubleRooms < 0){
            throw new IllegalArgumentException("Expected at least 0 doubleRooms, found: " + doubleRooms);
        }
        this.singleRooms = singleRooms;
        this.doubleRooms = doubleRooms;
    }

    /**
     * @return the number of booked single rooms
     */
    public int getSingleRooms(){
        return this.singleRooms;
    }

    /**
     * @return the number of booked double rooms
     */
    public int getDoubleRooms(){
        return this.doubleRooms;
    }

    /**
     * @return fixed price in pence for the rooms 
     */
    @Override
    public int getFixedPriceInPence(){
        return totalPriceInPence;
    }

    /**
     * Calculate number of persons in single and double rooms;
     * Per single room is 1 person and per double rooms are 2 persons
     * @param total number of person in each rooms.
     * @return total number of persons for the booked rooms
     */
    @Override
    public int getNumberOfPersons(){
        int total = getSingleRooms() + (getDoubleRooms() * 2);
        return total;
    }

    @Override
    public String toString() {
        return super.toString() + "\nLocation: " + this.getLocation()
        + "\nPrice: " + this.getFormattedPrice()
        + "\nSingle rooms: " + this.getSingleRooms()
        + "\nDouble rooms: " + this.getDoubleRooms();
    }
}
