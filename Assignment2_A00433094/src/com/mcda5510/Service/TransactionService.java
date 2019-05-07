package com.mcda5510.Service;

import java.sql.Connection;
import java.sql.SQLException;
import java.text.ParseException;
import java.util.logging.Logger;

import com.mcda5510.Dao.TransactionDao;
import com.mcda5510.entity.Transaction;

public interface TransactionService {
	public Transaction ValidateInput(Transaction trxn,Connection connection,TransactionDao dao,Logger logger) throws SQLException, ParseException ;
	
	public void createTransaction(Transaction trxn,Connection connection, TransactionDao dao,Logger logger) throws SQLException, ParseException;
	
	public void updateTransaction(Transaction trxn,Connection connection, TransactionDao dao,Logger logger) throws SQLException, ParseException;
	
	public void getTransaction(Connection connection, TransactionDao dao,Logger logger) throws SQLException, ParseException;
	
	public void deleteTransaction(Connection connection, TransactionDao dao,Logger logger) throws SQLException, ParseException;
	
	

}
