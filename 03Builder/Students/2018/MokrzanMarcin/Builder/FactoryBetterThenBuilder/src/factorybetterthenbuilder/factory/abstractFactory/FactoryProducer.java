/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorybetterthenbuilder.factory.abstractFactory;

import factorybetterthenbuilder.factory.product.factory.DlcFactory;
import factorybetterthenbuilder.factory.product.factory.GameFactory;

/**
 *
 * @author Marcin
 */
public class FactoryProducer {
    public static AbstractFactory getFactory(String choice){
        
        if(choice.equalsIgnoreCase("GAME")){
            return new GameFactory();
        }
        else if(choice.equalsIgnoreCase("DLC")){
            return new DlcFactory();
        }
        
        return null;
    }
    
}
