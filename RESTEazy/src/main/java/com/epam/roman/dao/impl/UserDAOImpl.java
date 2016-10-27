package com.epam.roman.dao.impl;

import java.util.List;

import javax.transaction.Transactional;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.model.User;
import com.epam.roman.util.HibernateUtil;

public class UserDAOImpl implements UserDAO {
	public UserDAOImpl() {}

	@Override
	@Transactional
	public List<User> list() {
		@SuppressWarnings("unchecked")
		List<User> list = (List<User>) HibernateUtil.getSessionFactory().openSession().createCriteria(User.class).list();

		return list;
	}

}