package com.epam.roman.test;

import com.epam.roman.ws.UserService;
import com.epam.roman.ws.UserServiceImplService;

public class UserServiceTest {
	public static void main(String[] args) {

		UserServiceImplService serviceImpl = new UserServiceImplService();
		
		UserService userService = serviceImpl.getUserServiceImplPort();
		
		userService.getAllUsers().getItem().forEach(x -> System.out.println(x.getLogin()));
	}
}
