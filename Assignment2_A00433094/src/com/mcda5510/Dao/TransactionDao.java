package com.mcda5510.Dao;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.ParseException;
import java.util.Collection;
import java.util.logging.Logger;

import com.mcda5510.entity.Transaction;

public interface TransactionDao {
	public Collection<Transaction> createTrxns(ResultSet resultSet,Logger logger) throws SQLException;
	public boolean createTransaction( Transaction trxn,Connection connection,Logger logger) throws SQLException, ParseException;
	public boolean updateTransaction(Transaction trxn,Connection connection,Logger logger) throws SQLException;
	public Collection<Transaction> getTransaction(int trxnID,Connection connection,Logger logger);
	public boolean removeTransaction(int trxnID,Connection connection,Logger logger);

}
