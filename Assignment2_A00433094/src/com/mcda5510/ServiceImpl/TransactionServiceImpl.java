package com.mcda5510.ServiceImpl;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.SQLException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.mcda5510.Dao.TransactionDao;
import com.mcda5510.Service.TransactionService;
import com.mcda5510.entity.Transaction;

public class TransactionServiceImpl implements TransactionService {
@Override	
public Transaction ValidateInput( Transaction trxn,Connection connection, TransactionDao dao,Logger logger) throws SQLException, ParseException {
		// TODO Auto-generated method stub
		// Input for ID 
		System.out.println("Please enter your ID :");
		@SuppressWarnings("resource")
		Scanner id = new Scanner(System.in);
		String idPattern = "^[1-9][0-9][0-9]$";  // Restricting User from entering a id in more than 3 digits
		String idFinal = id.nextLine();
		while(!idFinal.matches(idPattern)) {
			System.out.println("Please enter again");
			idFinal= id.nextLine();	
		}
		trxn.setId(Integer.parseInt(idFinal)); 
		
		// Input for Name 
		System.out.println("Please enter your name :");
		@SuppressWarnings("resource")
		Scanner name = new Scanner(System.in);
		String finalName=name.nextLine();
		while(!(finalName.matches("^[a-zA-Z][a-zA-Z\\s]*$")&&(finalName!=""))) { // Regex Allows spaces and alphabets for the name 
			System.out.println("Wrong format entered for name. Please try again.");
			finalName= name.nextLine();
			}
		trxn.setNameOnCard(finalName); 
		
		// Input for Card Type
		System.out.println("Please Select your Card Type : \n MasterCard - 1\nVisa - 2 \nAmerican Express - 3");
		@SuppressWarnings("resource")
		Scanner cardType = new Scanner(System.in);
		int crdTypSel=cardType.nextInt();
		String cardTypeSelected ="";
		String cardPattern ="";
		while(!((crdTypSel==1)||(crdTypSel==2)||(crdTypSel==3))) {
			System.out.println("Please select valid Card Type. Try Again.");
			crdTypSel=cardType.nextInt();
		}
		if(crdTypSel==1) {
			cardTypeSelected="MasterCard";
			cardPattern = "^[5][1-5]\\d{14}$";		// MasterCard cardNumber Check - Starts with 51-55 and 16 digits Length
		}
		else if(crdTypSel==2) {
			cardTypeSelected="Visa";
			cardPattern = "^[4]\\d{15}$";				// Visa cardNumber Check - Starts with 4 and 16 digits Length
		}
		else if(crdTypSel==3) {
			cardTypeSelected="American Express";
			cardPattern="^[3][4]\\d{13}$|^[3][7]\\d{13}$";	// American Express cardNumber Check - Starts with 34 or 37and 15 digits Length
		}
		trxn.setCreditCardType(cardTypeSelected);
		
		// Input Card Number 
		System.out.println("Please type your "+cardTypeSelected+" Number:");
		@SuppressWarnings("resource")
		Scanner cardNum = new Scanner(System.in);
		String cardNumber =cardNum.nextLine();
		while(!cardNumber.matches(cardPattern)) {   // Special characters are also not allowed in this.
			System.out.println("Wrong format entered for cardNumber. Please try again.");
			cardNumber=cardNum.nextLine();
			}
		trxn.setCardNumber(cardNumber); 
		
		// Input for Unit Price 
		System.out.println("Please enter your Unit Price :");
		@SuppressWarnings("resource")
		Scanner unitPrice = new Scanner(System.in);
		while(!unitPrice.hasNextBigDecimal()) {
			System.out.println("Wrong format entered for Unit Price. Please try again.");
			unitPrice.next();
		}
		BigDecimal unitPriceFinal = unitPrice.nextBigDecimal();
		trxn.setUnitPrice(unitPriceFinal);

		// Input for Quantity 
		System.out.println("Please enter your Quantity :");
		@SuppressWarnings("resource")
		Scanner qty = new Scanner(System.in);
		while(!(qty.hasNextInt())) {
			System.out.println("Wrong format entered for Quantity. Please try again.");
			qty.next();
			}
		int quantity=qty.nextInt();;
		trxn.setQuantity(quantity); 
		
		// For Total Price, i have calculated it by multiplying Quantity and Unit Price 
		
		// Input for Expiry Date
		System.out.println("Please enter your Expiry Date of Card in MM/YYYY Format :");
		@SuppressWarnings("resource")
		Scanner expDate = new Scanner(System.in);
		String expiryDate=expDate.nextLine();
		while(!expiryDate.matches("^(((0)[0-9])|((1)[0-2]))(\\/)(((2)(0)(1)[6-9])|((2)(0)(3)[0-1])|((2)(0)(2)[0-9]))$")) {
			System.out.println("Wrong format entered for Expiry Date. Please try again in MM/YYYY Format.");
			expiryDate= expDate.nextLine();
			}
		trxn.setExpDate(expiryDate); 
					
		return trxn;	
	}

	@Override
	public void createTransaction(Transaction trxn, Connection connection, TransactionDao dao,Logger logger)
			throws SQLException, ParseException {
		// TODO Auto-generated method stub
		boolean createObject = dao.createTransaction(trxn, connection,logger);
		if (createObject==true) {
			System.out.println("A New transaction has been created Succesfully");
			logger.log(Level.INFO, "New Transaction with transaction ID "+trxn.getId()+" created Succesfully");
		}
		
		else {
			logger.log(Level.INFO, "Error occured in creating the transaction as transaction id "+trxn.getId()+" already exists");
			System.out.println("Error occured as transaction Id provided by you already Exists.");
			System.out.println("Would you like to update a existing record ? please Type 'Yes' or 'No' Accordingly.");
			@SuppressWarnings("resource")
			Scanner createScanner = new Scanner(System.in);
			String answer = createScanner.nextLine();
			boolean result = false;
			while (!result) {
				if (answer.equalsIgnoreCase("Yes")) {
					boolean updateObject = dao.updateTransaction(trxn, connection,logger);
					if (updateObject==true) {
						System.out.println("Thank you. Your Transaction has been updated.");
						logger.log(Level.INFO, "Transaction updated Succesfully with transaction id "+trxn.getId()+"");
						result = true;}
					else {
						logger.log(Level.INFO, "Error Occured");
						result = true;
						}
				}	
				else if(answer.equalsIgnoreCase("No")) {
					System.out.println("Thank you. Your Transaction data would not be updated.");
					result = true;
				}
				else 
					System.out.println("Please enter valid input");
				if(result==false)
				createScanner.next();
			}
			System.out.println("Please continue with your selection.");
		}
			
		
	}

	@Override
	public void updateTransaction(Transaction trxn, Connection connection, TransactionDao dao,Logger logger)
			throws SQLException, ParseException {
		// TODO Auto-generated method stub
		boolean updateObject = dao.updateTransaction(trxn, connection,logger);
		if (updateObject==true) {
			System.out.println("Your transaction data has been updated Succesfully");
			logger.log(Level.INFO, "Row with "+trxn.getId()+" has been updated successfully");}
		else{
			logger.log(Level.INFO, "Transaction data for given transaction id "+trxn.getId()+" could not be updated as it does not exist.");
			System.out.println("Error occured in Updating the transaction as the transaction id provided by you does not exist.");
			System.out.println("Would you like to Create a transaction with same data ? please Type 'Yes' or 'No' Accordingly.");
			@SuppressWarnings("resource")
			Scanner createScanner = new Scanner(System.in);
			boolean result = false;
			while (!result) {
				if (createScanner.nextLine().equalsIgnoreCase("Yes")) {
					boolean createObject = dao.createTransaction(trxn, connection,logger);
					if (createObject==true) {
						System.out.println("New Transaction Created Succesfully");
						logger.log(Level.INFO, "New transaction has been created for the transaction id "+trxn.getId()+" provied. ");
						result = true;}
					else {
						System.out.println("Error occured");
						logger.log(Level.INFO, "Some Error Occured");
						result = true;
						}
				}	
				else if(createScanner.nextLine().equalsIgnoreCase("No")) {
					System.out.println("Thank you. Your Transaction data would not be updated.");
					result = true;
				}
				else 
					System.out.println("Please enter valid input");
				if(result==false)
				createScanner.next();
			}
			System.out.println("Please continue with your selection.");
		}
		
	}

	@Override
	public void getTransaction(Connection connection, TransactionDao dao,Logger logger)
			throws SQLException, ParseException {
		// TODO Auto-generated method stub
		System.out.println("Please enter the Transaction Id :");
		@SuppressWarnings("resource")
		Scanner inputId = new Scanner(System.in);
		while(!(inputId.hasNextInt())) {
			System.out.println("Transaction Id you have entered is not Valid. Please try with a valid Transaction Id.");
			inputId.next();
			}
		int trxnId=inputId.nextInt();
		System.out.println(trxnId);
		Collection<Transaction> transactionList = new ArrayList<Transaction>();
		transactionList = dao.getTransaction(trxnId, connection,logger);
		if(!transactionList.isEmpty()) {
			System.out.println("----------------------------------------------------------------------------------------------------------------------------------------------------------");
		    System.out.printf("%5s %10s %20s %20s %12s %12s %8s %15s %10s %15s", "ID", "NAME ON CARD", " CARD NUMBER ", "CREDIT CARD TYPE", "UNIT PRICE","QUANTITY", "TOTAL PRICE", "EXPIRY DATE", "CREATED ON", "CREATED BY");
		    System.out.println();
		    System.out.println("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			for (Iterator<Transaction> iterator = transactionList.iterator(); iterator.hasNext();) {
				Transaction transaction = (Transaction) iterator.next();
		
			    System.out.format("%5s %10s %20s %20s %10s %10s %8s %20s %20s %10s",
			                transaction.getId(), transaction.getNameOnCard(), transaction.getCardNumber(), transaction.getCreditCardType(), transaction.getUnitPrice(),transaction.getQuantity(),transaction.getTotalPrice(),transaction.getExpDate(),transaction.getCreatedOn(),transaction.getCreatedBy());
			    System.out.println();
			   
			}
			System.out.println("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			logger.log(Level.INFO, "Transaction data for the given transaction id "+trxnId+" has been retrieved successfully.");
		}
		else {
			System.out.println("Sorry !! Transaction Id provide by you does not Exist.");
			logger.log(Level.INFO, "Transaction data for the given transaction id "+trxnId+" cannot be retrieved as it does not exist.");
		}
		System.out.println("Please continue with your selection.");
	}

	@Override
	public void deleteTransaction(Connection connection, TransactionDao dao,Logger logger)
			throws SQLException, ParseException {
		// TODO Auto-generated method stub
		System.out.println("Please enter the Transaction Id :");
		@SuppressWarnings("resource")
		Scanner inputId = new Scanner(System.in);
		while(!(inputId.hasNextInt())) {
			System.out.println("Transaction Id you have entered is not Valid. Please try with a valid Transaction Id.");
			inputId.next();
			}
		int trxnId=inputId.nextInt();
		System.out.println(trxnId);
		boolean result = dao.removeTransaction(trxnId, connection,logger);
		if(result!=false) {
			System.out.println("Transaction removed successfully.");
			logger.log(Level.INFO, "Transaction data for the given transaction id "+trxnId+" has been removed");
			}
		else {
			System.out.println("An error occured. Transaction id provided by you does not exist in the table.");
			logger.log(Level.INFO, "Error Occured as transaction id provided by user does not exist.");
		}
		System.out.println("Please continue with your selection.");
	}
}
