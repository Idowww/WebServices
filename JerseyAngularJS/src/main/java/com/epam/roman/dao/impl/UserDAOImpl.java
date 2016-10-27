package com.epam.roman.dao.impl;

import java.util.List;

import javax.transaction.Transactional;

import org.hibernate.Session;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.model.User;
import com.epam.roman.util.HibernateUtil;

public class UserDAOImpl implements UserDAO {
	public UserDAOImpl() {
	}

	
	@Override
	@Transactional
	@SuppressWarnings("unchecked")
	public List<User> list() {
		Session session = HibernateUtil.getSessionFactory().openSession();
		List<User> list = (List<User>) session.createCriteria(User.class).list();

		return list;
	}
	
	@Override
	@Transactional
	public User get(Integer id) {
		Session session = HibernateUtil.getSessionFactory().openSession();
		return (User) session.get(User.class, id);
	}
	
	
	

	public static void main(String[] args)
			throws InstantiationException, IllegalAccessException, ClassNotFoundException {
		/*
		 * System.out.println("-------- PostgreSQL " +
		 * "JDBC Connection Testing ------------"); try {
		 * Class.forName("org.postgresql.Driver"); } catch
		 * (ClassNotFoundException e) {
		 * System.out.println("Where is your PostgreSQL JDBC Driver? " +
		 * "Include in your library path!"); e.printStackTrace(); return; }
		 * System.out.println("PostgreSQL JDBC Driver Registered!"); Connection
		 * connection = null; try { // ========> from heroku website String url
		 * =
		 * "jdbc:postgresql://ec2-54-243-245-58.compute-1.amazonaws.com:5432/dbv59kd8n6481g?sslmode=require";
		 * Properties props = new Properties(); props.setProperty("user",
		 * "kwpfcwhgwovfrs"); props.setProperty("password",
		 * "34FKI_EB3x_xaN3HPzy6vNhUsq"); props.setProperty("ssl", "true");
		 * connection = DriverManager.getConnection(url, props); } catch
		 * (SQLException e) {
		 * 
		 * System.out.println("Connection Failed! Check output console");
		 * e.printStackTrace(); return; }
		 */

		Session session = HibernateUtil.getSessionFactory().openSession();
		List<User> list = (List<User>) session.createCriteria(User.class).list();

	}
}