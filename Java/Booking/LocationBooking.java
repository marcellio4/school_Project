import java.util.Date;

/**
 * A LocationBooking is a booking for a fixed location.
 *
 * @author Marcel Zacharias
 */
public abstract class LocationBooking extends Booking {

	/** Location of the booking */
	private String location;

	/**
	 * Constructs a new LocationBooking with a name, a date and a location.
	 *
	 * @param name     the name for which the booking was made; must not be null
	 * @param date     the point in time for which the booking was made; must not be
	 *                 null and must not be in the past.
	 * @param location contain the adress of booking; must not be null
	 */
	public LocationBooking(String name, Date date, String location) {
		super(name, date);
		if (location == null) {
			throw new IllegalArgumentException("Location must not be null");
		}
		this.location = location;
	}

	/**
	 * @return the current location of booking
	 */
	public String getLocation() {
		return this.location;
	}
}
