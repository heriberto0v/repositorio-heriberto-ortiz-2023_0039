Public Class Form1

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim nombre As String = txtNombre.Text
        Dim sintoma As String = ""
        Dim nivel As String = ""


        If rbMareado.Checked Then
            sintoma = "mareado"
        ElseIf rbGanasDeVomitar.Checked Then
            sintoma = "ganas de vomitar"
        ElseIf rbFiebre.Checked Then
            sintoma = "fiebre"
        ElseIf rbDoloresMusculares.Checked Then
            sintoma = "dolores musculares"
        ElseIf rbFatiga.Checked Then
            sintoma = "fatiga"
        ElseIf rdEstres.Checked Then
            sintoma = "Estres"
        ElseIf rdIndigestion.Checked Then
            sintoma = "Indigestion"
        ElseIf rdCongestionNasal.Checked Then
            sintoma = "Congestion nasal"
        ElseIf rdInsomnio.Checked Then
            sintoma = "Insomnio"
        ElseIf rdAnsiedad.Checked Then
            sintoma = "Ansiedad"

        End If




        If rbBajo.Checked Then
            nivel = "bajo"
        ElseIf rbMedio.Checked Then
            nivel = "medio"
        ElseIf rbAlto.Checked Then
            nivel = "alto"
        End If


        Dim resultado As String = ""

        Select Case sintoma
            Case "mareado"
                Select Case nivel
                    Case "bajo"
                        resultado = "Descanse en casa."
                    Case "medio"
                        resultado = "Tome un acetaminofén y descanse."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select
            Case "ganas de vomitar"
                Select Case nivel
                    Case "bajo"
                        resultado = "Oler alcohol."
                    Case "medio"
                        resultado = "Tomar una pastilla gástrica."
                    Case "alto"
                        resultado = "Tomar una pastilla y estar en supervisión."

                End Select
            Case "fiebre"
                Select Case nivel
                    Case "bajo"
                        resultado = "Tomar una aspirina."
                    Case "medio"
                        resultado = "Aplicar una inyección."
                    Case "alto"
                        resultado = "Necesita hospitalización."

                End Select
            Case "dolores musculares"
                Select Case nivel
                    Case "bajo"
                        resultado = "Aplicar una crema."
                    Case "medio"
                        resultado = "Tomar un calmante."
                    Case "alto"
                        resultado = "Recibir sesiones de masajes."

                End Select
            Case "fatiga"
                Select Case nivel
                    Case "bajo"
                        resultado = "Proporcionar oxígeno."
                    Case "medio"
                        resultado = "Usar un respirador."
                    Case "alto"
                        resultado = "Necesita hospitalización."

                End Select
            Case "Estres"
                Select Case nivel
                    Case "bajo"
                        resultado = "Respiración profunda, realizar una actividad relajante y hablar con alguien cercano sobre tus preocupaciones"
                    Case "medio"
                        resultado = "Practicar técnicas de relajación como meditación o yoga, considerar la delegación de tareas y establecer límites claros."
                    Case "alto"
                        resultado = "Buscar apoyo profesional, considerar terapia, ajustar el estilo de vida para reducir el estrés y posiblemente considerar medicación bajo supervisión médica."

                End Select
            Case "Indigestion"
                Select Case nivel
                    Case "bajo"
                        resultado = " Evitar alimentos picantes o grasosos, beber agua y realizar una caminata ligera."
                    Case "medio"
                        resultado = " Tomar antiácidos de venta libre, evitar comidas pesadas, consumir alimentos suaves y no acostarse inmediatamente después de comer."
                    Case "alto"
                        resultado = "Consultar a un médico, evitar alimentos irritantes, seguir una dieta suave, considerar pruebas médicas y medicamentos recetados según sea necesario."

                End Select
            Case "Congestion nasal"
                Select Case nivel
                    Case "bajo"
                        resultado = " Inhalar vapor, usar un humidificador y beber líquidos calientes."
                    Case "medio"
                        resultado = "Usar descongestionantes de venta libre, descansar y mantener la cabeza elevada al dormir."
                    Case "alto"
                        resultado = "Consultar a un médico, considerar medicamentos recetados, tratamientos de alergia y evitar irritantes ambientales."

                End Select
            Case "Insomnio"
                Select Case nivel
                    Case "bajo"
                        resultado = "Evitar la cafeína antes de dormir, establecer una rutina de sueño y relajación antes de acostarse"
                    Case "medio"
                        resultado = "Prácticas de higiene del sueño, reducir la exposición a pantallas antes de dormir y considerar suplementos naturales como la melatonina."
                    Case "alto"
                        resultado = "Consultar a un médico, posible terapia cognitivo-conductual, considerar medicación para dormir bajo supervisión médica y abordar posibles causas subyacentes."

                End Select
            Case "Ansiedad"
                Select Case nivel
                    Case "bajo"
                        resultado = "Practicar técnicas de respiración, distracción mediante actividades agradables y hablar con amigos o familiares."
                    Case "medio"
                        resultado = "Considerar técnicas de relajación más profundas, como la meditación regular, y aprender a desafiar pensamientos ansiosos."
                    Case "alto"
                        resultado = " Buscar apoyo de un profesional de la salud mental, considerar la terapia cognitivo-conductual o medicamentos ansiolíticos bajo supervisión médica."

                End Select
        End Select

        lblResultado.Text = $"Estimado(a) {nombre}, basado en su síntoma de {sintoma} y su nivel de molestia {nivel}, se le recomienda: {resultado}"
        progressBar.Value = If(nivel = "bajo", 30, If(nivel = "medio", 60, 100))
        progressBar.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        progressBar.Visible = False
    End Sub


End Class
