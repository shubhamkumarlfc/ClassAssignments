package com.mcda5510.DaoImpl;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Types;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Collection;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.mcda5510.Dao.TransactionDao;
import com.mcda5510.entity.Transaction;


public class TransactionDaoImpl implements TransactionDao{
	@Override
	public Collection<Transaction> createTrxns(ResultSet resultSet,Logger logger) throws SQLException {
		Collection<Transaction> results = new ArrayList<Transaction>();

		// ResultSet is initially before the first data set
		try {
			while (resultSet.next()) {
				// It is possible to get the columns via name
				// also possible to get the columns via the column number
				// which starts at 1
				// e.g. resultSet.getSTring(2);
				Transaction trxn = new Transaction();
				trxn.setId(resultSet.getInt("ID"));
				trxn.setNameOnCard(resultSet.getString("NameOnCard"));
				trxn.setCardNumber(resultSet.getString("CardNumber"));
				trxn.setUnitPrice(resultSet.getBigDecimal("UnitPrice"));
				trxn.setQuantity(resultSet.getInt("Quantity"));
				trxn.setTotalPrice(resultSet.getBigDecimal("TotalPrice"));
				trxn.setExpDate(resultSet.getString("ExpDate"));
				trxn.setCreatedOn(resultSet.getString("CreatedOn"));
				trxn.setCreatedBy(resultSet.getString("CreatedBy"));
				trxn.setCreditCardType(resultSet.getString("CreditCardType"));
				trxn.toString();
				results.add(trxn);

			}

			
		}
		catch (Exception e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
			
		return results;

	}
	
	// Given a transaction object saves a row in the database (return success)
	// fails if ID exists in DB and prompts user to use update
	@Override
	public boolean createTransaction( Transaction trxn,Connection connection,Logger logger) throws SQLException, ParseException {
		// DO the Insert query here
		//PreparedStatement ps=null;
		CallableStatement cs=null;
		try {
			String userName=System.getProperty("user.name");
			//ps = connection.prepareStatement("Insert into `assignment2`.`Transaction` VALUES (?,?,?,"	+ "?,?,?,?,NOW(),'"+userName+"');");
			//ps = connection.prepareStatement("CALL CreateTransaction(?,?,?,?,?,?,?,"+userName+",?);");

			// Calling a Function instead of query to reduce one query of check for existing transaction
			cs = connection.prepareCall("{ ? = call CreateTransaction (?,?,?,?,?,?,?,?,?) }");
			cs.registerOutParameter(1, Types.INTEGER);
			cs.setInt(2, trxn.getId());
			cs.setString(3, trxn.getNameOnCard());
			cs.setString(4, trxn.getCardNumber());
			cs.setBigDecimal(5, trxn.getUnitPrice());
			cs.setInt(6, trxn.getQuantity());
			BigDecimal scaledUnitPrice = trxn.getUnitPrice().setScale(0, RoundingMode.HALF_UP);
			cs.setBigDecimal(7, scaledUnitPrice.multiply(new BigDecimal(trxn.getQuantity())));
			cs.setString(8, trxn.getExpDate());
			cs.setString(9, userName);
			cs.setString(10, trxn.getCreditCardType());
			int status = 0;
			ResultSet rs = cs.executeQuery(); 
			while (rs.next()) { 
				status= rs.getInt(1);
			}
			if (status!=0) {
				System.out.println("Row inserted");
				return true;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			cs = null;
		}
		return false;
	}
	
	// Given a transaction object saves a row in the database ( return success)
	// fails if ID does not exist in DB and prompts user to use create
	@Override
	public boolean updateTransaction(Transaction trxn,Connection connection,Logger logger) {
		// DO the update SQL here
		PreparedStatement ps=null;
		try {
			ps = connection.prepareStatement("UPDATE assignment2.Transaction SET NameOnCard = ?,CardNumber = ? ,"
					+ "UnitPrice = ?, Quantity=?, TotalPrice=?, ExpDate=?, CreditCardType=?  where ID = ? ;");
			ps.setString(1,trxn.getNameOnCard());
			ps.setInt(8, trxn.getId());
			ps.setString(2, trxn.getCardNumber());
			ps.setBigDecimal(3, trxn.getUnitPrice());
			ps.setInt(4, trxn.getQuantity());
			BigDecimal scaledUnitPrice = trxn.getUnitPrice().setScale(0, RoundingMode.HALF_UP);
			ps.setBigDecimal(5, scaledUnitPrice.multiply(new BigDecimal(trxn.getQuantity())));
			ps.setString(6, trxn.getExpDate());
			ps.setString(7, trxn.getCreditCardType());
			
			int status = ps.executeUpdate();
			if (status!=0) {
				return true;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			ps = null;
		}
		return false;
		
	}
	
	// Given a transaction ID returns a transaction object
	@Override
	public Collection<Transaction> getTransaction(int trxnID,Connection connection,Logger logger) {
		// DO the get transaction SQL here
		Statement statement = null;
		ResultSet resultSet = null;
		Collection<Transaction> results = new ArrayList<Transaction>();
		// Result set get the result of the SQL query
		try {
			// Statements allow to issue SQL queries to the database
			statement = connection.createStatement();
			resultSet = statement.executeQuery("select * from assignment2.transaction where id="+trxnID+" ;");
			results = createTrxns(resultSet,logger);
			if (resultSet != null) {
				resultSet.close();
			}

			if (statement != null) {
				statement.close();
			}

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			statement = null;
			resultSet = null;
		}
		return results;
	}
	
	// Given a transaction ID deletes a Transaction row in the DB
	@Override
	public boolean removeTransaction(int trxnID,Connection connection,Logger logger) {
		// DO the Delete SQL here
		PreparedStatement ps=null;
		try {
			ps = connection.prepareStatement("Delete from assignment2.Transaction where ID = ? ;");
			ps.setInt(1,trxnID);
			int status = ps.executeUpdate();
			if (status!=0) {
				return true;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			logger.log(Level.INFO, "Some Error Occured");
			logger.log(Level.INFO, e.getMessage(),e);
		} finally {
			ps = null;
		}
		return false;
		
	}
		
	

}
