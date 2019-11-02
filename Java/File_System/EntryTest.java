import static org.junit.Assert.*;
import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.Before;
import org.junit.Test;

public class EntryTest {

	private FileSystem fs;
	private Folder root;
	private File file;
	

	@Before
	public void setUp() throws Exception {
		fs = new FileSystem();
        root = fs.getRootFolder();
	}
	
	@Test 
	public void test_file_has_size_0() {
		assertEquals(0,root.getSize());
	}
	
	@Test
	public void test_file_has_size_50() {
		file = new File(root, "hello.txt", 50);
		assertEquals(50, file.getSize());
	}
	
	@Test
	public void test_root_folder_has_size_50() {
		file = new File(root, "hello.txt", 50);
		assertEquals(50, root.getSize());
	}
	
	@Test
	public void test_root_folder_has_size_0_after_remove_file() {
		file = new File(root, "hello.txt", 50);
		file.remove();
		assertEquals(0, root.getSize());
	}
	
	@Test
	public void test_file_is_in_the_system() {
		file = new File(root, "hello.txt", 50);
		assertTrue(file.isInFileSystem());
	}
	
	@Test
	public void test_file_is_not_in_the_system() {
		file = new File(root, "hello.txt", 50);
		file.remove();
		assertFalse(file.isInFileSystem());
	}
	
	@Test
	public void test_file_name() {
		file = new File(root, "hello.txt", 50);
		assertEquals("hello.txt",file.getName());
	}
	
	@Test
	public void test_file_name_path() {
		file = new File(root, "hello.txt", 50);
		assertEquals(Entry.SEPARATOR + "hello.txt",file.getPath());
	}
	
	@Test
	public void test_Folder_name_path() {
		Folder aFolder = new Folder(root, "aFolder");
		assertEquals(Entry.SEPARATOR + "aFolder" + Entry.SEPARATOR,aFolder.getPath());
	}
	
	@Test
	public void test_is_in_the_same_folder() {
		Folder aFolder = new Folder(root, "aFolder");
		FolderLink bFolder = new FolderLink(aFolder, "bFolder",aFolder);
		assertEquals(bFolder.getTarget(),bFolder.getTarget());
	}
	
	@Test
	public void test_original_file_is_in_the_system() {
		 file = new File(root, "aName.txt", 48);
	     FileLink bName = new FileLink(root, "bName.txt", file);
	     bName.remove();
		 assertTrue(file.isInFileSystem());
	}
	
	@Test
	public void test_file_link_is_not_in_the_system() {
		 file = new File(root, "aName.txt", 48);
	     FileLink bName = new FileLink(root, "bName.txt", file);
	     bName.remove();
		 assertFalse(bName.isValidLink());
	}
	
	@Test(expected = IllegalArgumentException.class)
	public void test_folder_with_null_reference() {
		 Folder folder = new Folder(root, null);
	}
	
	@Test(expected = IllegalArgumentException.class)
	public void test_two_files_with_the_same_name() {
		 File f = new File(root, "f", 20);
		 File f2 = new File(root, "f", 30);
	}

}
