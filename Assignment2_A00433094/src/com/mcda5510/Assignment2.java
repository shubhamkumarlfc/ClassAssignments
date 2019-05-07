package com.mcda5510;

import java.sql.Connection;
import java.util.Scanner;
import java.util.logging.FileHandler;
import java.util.logging.Handler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

import com.mcda5510.Dao.TransactionDao;
import com.mcda5510.DaoImpl.TransactionDaoImpl;
import com.mcda5510.Service.TransactionService;
import com.mcda5510.ServiceImpl.TransactionServiceImpl;
import com.mcda5510.connectDb.ConnectionMysql;
import com.mcda5510.entity.Transaction;

public class Assignment2 {
	
	public static Connection single_instance;

	public static Connection getInstance(Logger logger) {
		if (single_instance == null) {
			ConnectionMysql dbConnection = new ConnectionMysql();
			single_instance = dbConnection.setupConnection(logger);
		}
		return single_instance;
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Handler fh = null;
    	Logger logger = null;
		TransactionDao dao= new TransactionDaoImpl();
		boolean validChoice = true;
		int choice = 0;
		try {			
			logger=Logger.getLogger("Main");
    		fh = new FileHandler("./Logs/Assignment2LogFile.log");
    		fh.setFormatter(new SimpleFormatter());  // Set the log format
	    	logger.setUseParentHandlers(false);
	        // Add the FileHandler to the logger.
	        logger.addHandler(fh);
    		Connection connection= getInstance(logger);
    		Transaction trxn= new Transaction();
    		TransactionService service = new TransactionServiceImpl();
    		
    		displayMenu();
    		
    		Scanner scanner = new Scanner(System.in);
    		while (validChoice) {
    			if (scanner.hasNextInt()) {
    				choice = scanner.nextInt();
    				if(choice ==1 ) {
    					logger.log(Level.INFO, "Create a transaction - 1 : Selected");
    					trxn = service.ValidateInput(trxn, connection, dao,logger);
    					service.createTransaction(trxn, connection, dao,logger);
    					displayMenu();
    				}
    				else if(choice ==2 ) {
    					logger.log(Level.INFO, "Update a transaction - 2 : Selected");
    					trxn = service.ValidateInput(trxn, connection, dao,logger);
    					service.updateTransaction(trxn, connection,dao,logger);
    					displayMenu();
    				}
    				else if(choice ==3 ) {
    					logger.log(Level.INFO, "Remove a transaction - 3 : Selected");
    					service.deleteTransaction(connection, dao,logger);
    					displayMenu();
    				}
    				else if(choice ==4) {
    					logger.log(Level.INFO, "Get a transaction - 4 : Selected");
    					service.getTransaction(connection, dao,logger);
    					displayMenu();
    				}
    				else if(choice ==5) {
    					logger.log(Level.INFO, "Exit successfull");
    					validChoice=false;
    				}
    				else
    					System.out.println("Wrong choice. Please enter again.");
    			}
    			else {
    				System.out.println("Wrong choice. Please enter again.");
    			}
    			scanner.nextLine();
    			}
    		scanner.close();
    		System.out.println("Thankyou. Hope to see you again soon.");
    		logger.log(Level.INFO, "Thankyou. Hope to see you again soon.");
		
		}
		catch (Exception e) {
			// TODO: handle exception
			logger.log(Level.INFO, "Some Error Occured");
			logger.log(Level.INFO, e.getMessage(),e);
		}
		finally {
    		//Closing and Flushing of File handler
 	        fh.flush();
 		    fh.close();
    	}
	}
	
	public static void displayMenu() {
		System.out.println("");
		System.out.println("Welcome to Assignment 2: MCDA 5510");
		System.out.println("Please select one of the following operations to perform :");
		System.out.println("Create a new Transaction - 1");
		System.out.println("Update a existing Transaction - 2");
		System.out.println("Delete a existing Transaction - 3");
		System.out.println("Get a transaction - 4");
		System.out.println("Exit - 5");
		System.out.println();
		System.out.print("Please Enter your Choice Here :");
	}
	

}
