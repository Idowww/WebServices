package com.epam.roman.publisher;

import javax.xml.ws.Endpoint;

import com.epam.roman.ws.UserServiceImpl;

public class UserServicePublisher {
	public static void main(String[] args) {
		
        Endpoint.publish("http://localhost:9898/ws/user", new UserServiceImpl());
        
        System.out.println("Successfully deployed");
   }
}
