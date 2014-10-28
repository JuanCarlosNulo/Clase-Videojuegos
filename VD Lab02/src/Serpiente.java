
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.lang.reflect.InvocationTargetException;
import java.util.LinkedList;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;


public class Serpiente extends JPanel implements KeyListener {
   private static final int TAMBLOQUE=20;
   
   public Serpiente() {
      nuevaComida();
      puntos=0;
      dir=Direccion.DER;
      Posicion init=new Posicion();
      init.x=6; init.y=5;
      cuerpo.addLast(init);
      init=new Posicion();
      init.x=5; init.y=5;
      cuerpo.addLast(init);
   }
   
   private enum Direccion { IZQ, DER, ARR, ABJ };
   private Direccion dir;
   
   private long puntos;
   
   private class Posicion { 
      int x,y;
      
      @Override
      public boolean equals(Object obj) {
         return ((Posicion)obj).x==x && ((Posicion)obj).y==y;
      }
   }
   
   private Posicion comida;
   private void nuevaComida() {
      do {
         comida=new Posicion();
         comida.x=(int)Math.round(Math.random()*this.getWidth())/TAMBLOQUE;
         comida.y=(int)Math.round(Math.random()*this.getHeight())/TAMBLOQUE;
      }while(cuerpo.contains(comida));
   }
   
   private LinkedList<Posicion> cuerpo=new LinkedList<Posicion>();
   private void avanzar() {
      Posicion npos=new Posicion();
      npos.x=cuerpo.getFirst().x;
      npos.y=cuerpo.getFirst().y;
      switch(dir) {
      case IZQ:
         npos.x--;
         break;
      case DER:
         npos.x++;
         break;
      case ARR:
         npos.y--;
         break;
      case ABJ:
         npos.y++;
      }
      boolean pierde=false;
      if(npos.x==comida.x && npos.y==comida.y) {
         puntos++;
         nuevaComida();
      }
      else {
         cuerpo.removeLast();
      } 

      pierde=pierde||cuerpo.contains(npos);
      pierde=pierde||npos.x<0||npos.y<0;
      pierde=pierde||npos.x>this.getWidth()/TAMBLOQUE;
      pierde=pierde||npos.y>this.getHeight()/TAMBLOQUE;
      
      cuerpo.addFirst(npos);
      
      if(pierde) {
         try {
            SwingUtilities.invokeAndWait(new Runnable() {
               @Override
               public void run() {
                  JOptionPane.showMessageDialog(Serpiente.this, "Game Over");
                  System.exit(0);
               }
            });
         } catch (Exception e) {
            System.exit(1);
         }
      }
   }
   
   public void juego() {
      for(;;) {
         try {
            Thread.sleep(500L-(puntos*10));
         } catch (InterruptedException e) {
         }
         
         avanzar();
         
         SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
            	Serpiente.this.repaint();
            }
         });
      }
   }
   
   @Override
   protected void paintComponent(Graphics gg) {
      super.paintComponent(gg);
      gg.drawString(Long.toString(puntos), 10, this.getHeight()-10);
      for(Posicion p : cuerpo)
        gg.fillRect(p.x*TAMBLOQUE, p.y*TAMBLOQUE, TAMBLOQUE, TAMBLOQUE);
      gg.setColor(Color.red);
      gg.fillOval(comida.x*TAMBLOQUE, comida.y*TAMBLOQUE, TAMBLOQUE, TAMBLOQUE);
   }
   
public void keyPressed(KeyEvent ke) {
   switch(ke.getKeyCode()) {
   case KeyEvent.VK_LEFT:
      if(!dir.equals(Direccion.DER)) dir=Direccion.IZQ;
      break;
   case KeyEvent.VK_RIGHT:
      if(!dir.equals(Direccion.IZQ)) dir=Direccion.DER;
      break;
   case KeyEvent.VK_UP:
      if(!dir.equals(Direccion.ABJ)) dir=Direccion.ARR;
      break;
   case KeyEvent.VK_DOWN:
      if(!dir.equals(Direccion.ARR)) dir=Direccion.ABJ;
      break;
   }
}
   public void keyReleased(KeyEvent arg0) {}
   public void keyTyped(KeyEvent arg0) {}
   
   public static void main(String[] args) {
	  Serpiente main=new Serpiente();
      JFrame frame=new JFrame();
      frame.setTitle("SNAKE");
      frame.addKeyListener(main);
      frame.setContentPane(main);
      frame.setSize(600, 400);
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setVisible(true);
      
      main.juego();
   }
}