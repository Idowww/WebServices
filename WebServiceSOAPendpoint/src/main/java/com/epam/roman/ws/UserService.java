package com.epam.roman.ws;

import javax.jws.WebMethod;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;

import com.epam.roman.model.User;

@WebService
@SOAPBinding(style = SOAPBinding.Style.RPC)
public interface UserService {
 
    @WebMethod
    public void addUser(User user);
     
    @WebMethod
    public void deleteUser(int id);
     
    @WebMethod
    public User getUser(int id);
     
    @WebMethod
    public User[] getAllUsers();
}