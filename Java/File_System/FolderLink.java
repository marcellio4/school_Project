/**
 * A symbolic link to a folder in a file system.
 * 
 * @author Roman Kontchakov
 * @author Carsten Fuhs
 * @author Marcel Zacharias
 */
public class FolderLink extends Link<Folder> {

    /**
     * Constructs a new link to a folder.
     *
     * @param parent the parent folder of this link; must not be null 
     * @param name the name of this link; must not be null
     * @param target the folder to which this links points; must not be null 
     */
    public FolderLink(Folder parent, String name, Folder target) {
        super(parent, name, target);
    }
    
    /* (non-Javadoc)
     * @see AbstractEntry#getPath()
     */
    @Override
    public String getPath() {
    	return  getTarget() + getName() + SEPARATOR;
    }
    
    /* (non-Javadoc)
     * @see java.lang.Object#equals(java.lang.Object)
     */
    @Override
    public boolean equals(Object obj) {
        if (this == obj)
            return true;
        if (!super.equals(obj))
            return false;
        return obj instanceof FolderLink;
    }
}
