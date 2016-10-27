package com.epam.roman.dao.impl;

import java.util.List;

import org.hibernate.Session;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.model.User;
import com.epam.roman.util.HibernateUtil;

public class UserDAOImpl implements UserDAO {
	
	public UserDAOImpl() {
	}
	
	@Override
	public User get(Integer id) {
		Session session = HibernateUtil.getSessionFactory().openSession();
		session.beginTransaction();
		
		User user = (User) session.get(User.class, id);
		
		session.getTransaction().commit();
		return user;
	}

	@Override
	public List<User> getAll() {
		Session session = HibernateUtil.getSessionFactory().openSession();
		session.beginTransaction();
		
		@SuppressWarnings("unchecked")
		List<User> list = (List<User>) session.createCriteria(User.class).list();
		
		session.getTransaction().commit();
		return list;
	}

	@Override
	public void delete(Integer id) {
		Session session = HibernateUtil.getSessionFactory().openSession();
		session.beginTransaction();
		
		User user = (User) session.get(User.class, id);
		session.delete(user);
		
		session.getTransaction().commit();
	}

	@Override
	public Integer insert(User user) {
		Session session = HibernateUtil.getSessionFactory().openSession();
		session.beginTransaction();
		
		session.save(user);
		
		session.getTransaction().commit();
		return user.getId();
	}

	@Override
	public void update(User user) {
		Session session = HibernateUtil.getSessionFactory().openSession();
		session.beginTransaction();
		
		session.update(user);
		
		session.getTransaction().commit();
	}
}