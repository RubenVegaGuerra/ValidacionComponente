import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;

public class MainWindow extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainWindow frame = new MainWindow();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public MainWindow() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		// DNI
		JLabel lblNewLabel = new JLabel("DNI");
		lblNewLabel.setBounds(43, 35, 46, 14);
		contentPane.add(lblNewLabel);

		MiControl miControlDNI = new MiControl("DNI");
		miControlDNI.setBounds(120, 0, 434, 96);
		getContentPane().add(miControlDNI);

		// CP
		JLabel lblCodigoPostal = new JLabel("Codigo Postal");
		lblCodigoPostal.setBounds(43, 112, 79, 14);
		contentPane.add(lblCodigoPostal);

		MiControl miControlCP = new MiControl("CP");
		miControlCP.setBounds(120, 75, 434, 96);
		getContentPane().add(miControlCP);

		// TEL
		JLabel lblTelfono = new JLabel("Tel\u00E9fono");
		lblTelfono.setBounds(43, 184, 79, 14);
		contentPane.add(lblTelfono);

		MiControl miControlTEL = new MiControl("TEL");
		miControlTEL.setBounds(120, 150, 434, 96);
		getContentPane().add(miControlTEL);

	}
}
