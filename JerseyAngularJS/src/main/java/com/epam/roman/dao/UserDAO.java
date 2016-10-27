package com.epam.roman.dao;

import java.util.List;

import com.epam.roman.model.User;

public interface UserDAO {
	public List<User> list();
	public User get(Integer id);
}
