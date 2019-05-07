package com.mcda5510.connectDb;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ConnectionMysql {
	
	static Connection connection=null;
	static String databaseName= "assignment2";
	static String url = "jdbc:mysql://localhost:3306/"+databaseName;
	
	static String username = "root";
	static String password = "root";

	public Connection setupConnection(Logger logger)  {

		// TODO Auto-generated method stub
		try {
			// This will load the MySQL driver, each DB has its own driver
			Class.forName("com.mysql.jdbc.Driver");
			// Setup the connection with the DB
			connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/assignment2?"+ "user=root&password=root" // Creds
				+ "&useSSL=false" // b/c localhost
				+ "&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC");
			logger.log(Level.CONFIG, "Successfully Connected to Database");
			
		} catch (Exception e) {
			logger.log(Level.CONFIG, "Error setting up connection");
			e.printStackTrace();
		} finally {
			
		}
		return connection;
	}

}
