import java.util.Date;

/**
 * A RestaurantBooking is a booking at a specific location for a given number of
 * persons.
 * 
 * @author Marcel Zacharias
 */
public class RestaurantBooking extends LocationBooking {

	/** Number of person at least 1 */
	private int numberOfPersons;

	/**
	 * Constructs a new RestaurantBooking according to the parameters.
	 *
	 * @param name            the name for which the booking was made; must not be
	 *                        null
	 * @param date            the point in time for which the booking was made; must
	 *                        not be null and must not be in the past
	 * @param location        the address of the restaurant; must not be null
	 * @param numberOfPersons the number of persons for whom the booking is made; at
	 *                        least 1
	 */
	public RestaurantBooking(String name, Date date, String location, int numberOfPersons) {
		super(name, date, location);
		if (numberOfPersons < 1) {
			throw new IllegalArgumentException("Number of person must be at least 1");
		}
		this.numberOfPersons = numberOfPersons;
	}

	/**
	 * @return the number of persons in restaurant
	 */
	@Override
	public int getNumberOfPersons() {
		return this.numberOfPersons;
	}

	@Override
	public String toString() {
		return super.toString() + "\nLocation: " + this.getLocation();
	}
}
