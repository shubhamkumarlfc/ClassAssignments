package org.main;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Reader;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import org.apache.commons.csv.CSVFormat;
import org.apache.commons.csv.CSVPrinter;
import org.apache.commons.csv.CSVRecord;

public class ReadWriteCsv {
	
	public String readWriteCsvFile(ArrayList<String> fileNames,Logger logger,int skippedRows,int goodRows)throws IOException,IndexOutOfBoundsException, ParseException {
	    	Reader in;
	      	CSVPrinter csvPrinter = null;
	    	CSVPrinter csvPrinter2 = null;
	    	FileWriter fileWriter = null;
	    	String ValidRows = "";
	    	String badRows ="";
	    	
			try {
				fileWriter =  new FileWriter("./Output/ValidRows.csv");
		        csvPrinter = new CSVPrinter(fileWriter, CSVFormat.EXCEL);
				//Printing Header rows for good Rows csv
		        csvPrinter.printRecord("First Name","Last Name","Street number",
		        		"Street","City","Province","Postal Code","Country","Phone","Email","Date");
		        csvPrinter2 = new CSVPrinter(new FileWriter("./Output/BadRows.csv"), CSVFormat.EXCEL);
		        
		        //Printing Header rows for Skipped Rows csv
		        csvPrinter2.printRecord("First Name","Last Name","Street number",
		        		"Street","City","Province","Postal Code","Country","Phone","Email","Date");
		        
		        // For Loop for traversing all the files 
				for (int i = 0; i < fileNames.size(); i++) { 
					
					in = new FileReader(fileNames.get(i));
					Iterable<CSVRecord> records = CSVFormat.EXCEL.parse(in);
					
					//Bonus - Used regex to extract date
					final String regex = "\\d{4}-\\d{1,2}-\\d{1,2}"; //will take first 4 digits-1 or two digits-1 or two digits
					final Pattern pattern = Pattern.compile(regex, Pattern.MULTILINE);
					final Matcher matcher = pattern.matcher(fileNames.get(i).replace('\\', '-'));
					matcher.find();
					String date = matcher.group(0);
				    Date stringToDate = new SimpleDateFormat("yyyy-mm-dd").parse(date);
				    String finalDate = new SimpleDateFormat("dd-mm-yyyy").format(stringToDate);
				    
				    // For Loop for traversing all the records
					for (CSVRecord record : records) {
						
						if(record.size()==10) {
							String firstName = record.get(0);
							String lastName = record.get(1);
						    String streetNumber = record.get(2);
						    String street = record.get(3);
						    String city = record.get(4);
						    String province = record.get(5);
						    String postalCode = record.get(6);
						    String country = record.get(7);
						    String phoneNumber = record.get(8);
						    String email = record.get(9);
						    if ((firstName.isEmpty())||(lastName.isEmpty())||(streetNumber.isEmpty())||(street.isEmpty())||(city.isEmpty())
					    		||(province.isEmpty())||(postalCode.isEmpty())||(country.isEmpty())||(phoneNumber.isEmpty())||(email.isEmpty())
					    		) 
						    {
						    	// Add to the counter of the skipped rows as it is a bad row.
						    	if(record.getRecordNumber()!=1) { //skipping the 1st record as its header 
						    		skippedRows++;
						    		csvPrinter2.printRecord(firstName,lastName,streetNumber,street,city,province,postalCode,country,phoneNumber,email,finalDate);
						    		//Not logging the skipped rows as it takes a lot of time. Also i am printing bad rows in a different csv.
						    		//	logger.log(Level.SEVERE," Skipped Row :"+record);
						    	}
							    
						    }
						    else {
						    	// Printing it for all the good data
						    	if(record.getRecordNumber()!=1) {  //skipping the 1st record as its header 
						    		csvPrinter.printRecord(firstName,lastName,streetNumber,street,city,province,postalCode,country,phoneNumber,email,finalDate);
						    		goodRows++;
						    	}   	
						    	}
					    }
						else {
							// add to the counter of the skipped rows as it is a bad row which does not has the right record size. 
							if(record.getRecordNumber()!=1) {
								csvPrinter2.printRecord(record,finalDate);
								skippedRows++;
								//Not logging the skipped rows as it takes a lot of time. Also i am printing bad rows in a different csv.
								//logger.log(Level.SEVERE," Skipped Row :"+record);
							}
						}
					}	
				}
				ValidRows=String.valueOf(goodRows);
				badRows = String.valueOf(skippedRows);
			}
		catch (IndexOutOfBoundsException e) {
	    	logger.log(Level.WARNING,"Some Error Occured. Please check logs for more info.");
	    	logger.log(Level.WARNING,e.getMessage(),e);
		}
		catch (IllegalStateException e) {
		    	logger.log(Level.WARNING,"Some Error Occured. Please check logs for more info.");
		    	logger.log(Level.WARNING,e.getMessage(),e);
			}
		catch (ParseException e) {
		    	logger.log(Level.WARNING,"Some Error Occured. Please check logs for more info.");
		    	logger.log(Level.WARNING,e.getMessage(),e);
			}
		catch ( IOException e) {
			logger.log(Level.WARNING,"Some Error Occured. Please check logs for more info.");
			logger.log(Level.WARNING,e.getMessage(),e);
		}
		finally {
	    		//Closing and Flushing of File Writer, Csv Printer 
			fileWriter.flush();
	        fileWriter.close();
	        csvPrinter.close();
	        csvPrinter2.close();
	    	}
			return ValidRows+","+badRows;
	}


}
