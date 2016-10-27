package com.epam.roman.dao;

import java.util.List;

import com.epam.roman.model.User;

public interface UserDAO {
	public User get(Integer id);
	public List<User> getAll();
	public void delete(Integer id);
	public Integer insert(User user);
	public void update(User user);
	
}
