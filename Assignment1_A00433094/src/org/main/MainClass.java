package org.main;

import java.io.File;
import java.io.IOException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.logging.FileHandler;
import java.util.logging.Handler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class MainClass {
	ArrayList<String> fileNames = new ArrayList<String>();
	
    public static void main(String[] args) throws IOException, IndexOutOfBoundsException, ParseException {
    	
    	Handler fh = null;
    	Logger logger = null;
    	int goodRows=0;
    	int skippedRows=0;
    	int totalRows=0;
  
    	try {
    		logger=Logger.getLogger("Main");
    		fh = new FileHandler("./Logs/sampleLogfile.log");
	    	fh.setFormatter(new SimpleFormatter());  // Set the log format
	    	logger.setUseParentHandlers(false);
	        // Add the FileHandler to the logger.
	        logger.addHandler(fh);
	        // Set the logger level to produce logs at this level and above.
	        logger.setLevel(Level.FINE);
	        final long startTime = System.currentTimeMillis();
	        MainClass fw = new MainClass();
	        //Traversing through the Directory 
	        fw.walk("C:\\Users\\shubh\\Documents\\GitHub\\MCDA5510_Assignments\\Sample Data\\Sample Data\\" );
	
	        ReadWriteCsv readWriteCsv = new ReadWriteCsv();;
	    	String result = readWriteCsv.readWriteCsvFile(fw.fileNames,logger,goodRows,skippedRows);	
	        String [] finalresult = result.split(",");
		    final long endTime = System.currentTimeMillis();
		    totalRows = Integer.parseInt(finalresult[1])+Integer.parseInt(finalresult[0]);
		    logger.log(Level.SEVERE," Total Number of Rows : "+totalRows);
		    logger.log(Level.SEVERE," Total Number of Skipped Rows : "+finalresult[1]);
		    logger.log(Level.SEVERE," Total Number of Valid Rows : "+finalresult[0]);
		    logger.log(Level.INFO, "Total execution time: " + (endTime - startTime) + " ms");
    		} 
    	catch ( IOException e) {
			// TODO Auto-generated catch block
			logger.log(Level.WARNING,"The process cannot access the file because it is being used by another process");
			logger.log(Level.WARNING,e.getMessage(),e);
			}
    	finally {
    		//Closing and Flushing of File handler
 	        fh.flush();
 		    fh.close();
    	}
		 
    }
	
    
	public void walk( String path ) {

        File root = new File( path );
        File[] list = root.listFiles();

        if (list == null) return;

        for ( File f : list ) {
            if ( f.isDirectory() ) {
                walk( f.getAbsolutePath() );
            }
            // To make sure the file added are csv files only
            else if(f.getAbsolutePath().endsWith(".csv")) {
            	fileNames.add(f.getAbsolutePath().toString());
            }
        }
    }
	
}
