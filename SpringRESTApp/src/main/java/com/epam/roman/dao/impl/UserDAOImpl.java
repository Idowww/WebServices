package com.epam.roman.dao.impl;

import java.util.List;

import javax.transaction.Transactional;

import org.hibernate.Session;
import org.hibernate.SessionFactory;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.model.User;

public class UserDAOImpl implements UserDAO {
    private SessionFactory sessionFactory;
 
    public UserDAOImpl(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }
    
    public UserDAOImpl() {
	}
	
	@Override
	@Transactional
	public User get(Integer id) {
		User user = (User) sessionFactory.getCurrentSession().get(User.class, id);
		return user;
	}

	@Override
	@Transactional
	public List<User> getAll() {
		@SuppressWarnings("unchecked")
		List<User> list = (List<User>) sessionFactory.getCurrentSession().createCriteria(User.class).list();
		return list;
	}

	@Override
	@Transactional
	public void delete(Integer id) {
		Session session = sessionFactory.getCurrentSession();
		
		User user = (User) session.get(User.class, id);
		session.delete(user);
	}

	@Override
	@Transactional
	public Integer insert(User user) {
		sessionFactory.getCurrentSession().save(user);
		return user.getId();
	}

	@Override
	@Transactional
	public void update(User user) {
		sessionFactory.getCurrentSession().update(user);
	}
 
}