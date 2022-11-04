import { useEffect, useState } from "react";
import Graph from "./Graph";
import "../App.css";

export default function CountryList() {
	const [loading, setLoading] = useState(false);
	const [countryList, setCountryList] = useState();
	const [selectedCountry, setSelectedCountry] = useState();
	const [countrySent, setCountrySent] = useState();
	const [closed, setClosed] = useState(true);

	useEffect(() => {
		fetch("http://localhost:5152/api/Case")
			.then((res) => res.json())
			.then((json) => {
				setCountryList(json);
				setLoading(true);
				setClosed(false);
				console.log(countryList);
			});
	}, []);

	const handleCountrySelect = (country) => {
		setSelectedCountry(country);
		console.log(selectedCountry + "selected");
	};

	useEffect(() => {
		setCountrySent(selectedCountry);
		console.log(countrySent);
	}, [selectedCountry]);

	if (loading === false) {
		return <></>;
	}
	return (
		<>			
		<div className="selection">
						{countryList.map((country) => (
							<button
								value={country}
								onClick={() => handleCountrySelect(country)}
							>
								{country}
							</button>
						))}
		</div>
			<Graph country={countrySent} />
		</>
	);
}
