package com.epam.roman.publisher;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.Arrays;

import javax.xml.namespace.QName;
import javax.xml.ws.Service;

import com.epam.roman.ws.UserService;

public class SOAPPublisherClient {
	 
    public static void main(String[] args) throws MalformedURLException {
        URL wsdlURL = new URL("http://localhost:9898/ws/user?wsdl");
        //check above URL in browser, you should see WSDL file
         
        //creating QName using targetNamespace and name
        QName qname = new QName("http://ws.roman.epam.com/", "UserServiceImplService"); 
         
        Service service = Service.create(wsdlURL, qname);  
         
        //We need to pass interface and model beans to client
        UserService ps = service.getPort(UserService.class);
         
        //get all persons
        System.out.println(Arrays.asList(ps.getAllUsers()));
         
    }
 
}