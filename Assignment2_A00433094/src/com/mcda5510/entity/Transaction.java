package com.mcda5510.entity;

import java.math.BigDecimal;

public class Transaction{
	
	private int id;
	private String nameOnCard;
	private String cardNumber;
	private BigDecimal unitPrice;
	private int quantity;
	private BigDecimal totalPrice;
	private String expDate;
	private String createdOn;
	private String createdBy;
	private String creditCardType;
	
	public String getCardNumber() {
		return cardNumber;
	}
	public void setCardNumber(String cardNumber) {
		this.cardNumber = cardNumber;
	}
	
	public String getNameOnCard() {
		return nameOnCard;
	}
	public void setNameOnCard(String nameOnCard) {
		this.nameOnCard = nameOnCard;
	}	
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public BigDecimal getUnitPrice() {
		return unitPrice;
	}
	public void setUnitPrice(BigDecimal unitPrice) {
		this.unitPrice = unitPrice;
	}
	public int getQuantity() {
		return quantity;
	}
	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}
	public BigDecimal getTotalPrice() {
		return totalPrice;
	}
	public void setTotalPrice(BigDecimal totalPrice) {
		this.totalPrice = totalPrice;
	}
	public String getExpDate() {
		return expDate;
	}
	public void setExpDate(String expDate) {
		this.expDate = expDate;
	}
	public String getCreatedOn() {
		return createdOn;
	}
	public void setCreatedOn(String createdOn) {
		this.createdOn = createdOn;
	}
	public String getCreatedBy() {
		return createdBy;
	}
	public void setCreatedBy(String createdBy) {
		this.createdBy = createdBy;
	}
	public String toString(){
		
		String results = new String();
		
		results = "[Id: "+id+",NameOnCard: " + nameOnCard +",CardNumber: " + cardNumber+","
				+ "Unit Price: "+unitPrice+",Quantity: "+quantity+",Total Price: "+totalPrice+","
						+ "Expiry Date: "+expDate+",Created On: "+createdOn+",Created By:"+createdBy+",Credit Card Type:"+creditCardType+"]";
		return results;

	}
	public String getCreditCardType() {
		return creditCardType;
	}
	public void setCreditCardType(String creditCardType) {
		this.creditCardType = creditCardType;
	}

	
	
}
