package com.epam.roman.ws;


import java.util.List;

import javax.jws.WebService;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.dao.impl.UserDAOImpl;
import com.epam.roman.model.User;

@WebService(endpointInterface = "com.epam.roman.ws.UserService")
public class UserServiceImpl implements UserService {

	private static UserDAO userDAO = new UserDAOImpl();

	@Override
	public void addUser(User user) {
		System.out.println("addUser: " + user);

		userDAO.insert(user);
	}

	@Override
	public void deleteUser(int id) {
		System.out.println("deleteUser, id=" + id);
		
		userDAO.delete(id);
	}

	@Override
	public User getUser(int id) {
		System.out.println("getUser, id=" + id);
		
		return userDAO.get(id);
	}

	@Override
	public User[] getAllUsers() {
		System.out.println("getAllUsers");
		
		List<User> users = userDAO.getAll();
		return users.toArray(new User[users.size()]);
	}

}