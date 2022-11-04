import { useEffect, useState } from "react";
import Graph from "./Graph";
import "../App.css";

export default function CountryList() {
	const [loading, setLoading] = useState(false);
	const [countryList, setCountryList] = useState();
	const [selectedCountry, setSelectedCountry] = useState();
	const [countrySent, setCountrySent] = useState();
	const [listShown, setListShown] = useState (false);

	let listToggle="selectionOff";
	const handleCountrySelect = (country) => {
		setSelectedCountry(country);
		setListShown (false)
		console.log(selectedCountry + "selected");
	};
	const showList =() =>{
		if(listShown===false){
			setListShown(true)
		}
		if (listShown===true){
			setListShown(false)
		}
	}

	useEffect(() => {
		fetch("http://localhost:5152/api/Case")
			.then((res) => res.json())
			.then((json) => {
				setCountryList(json);
				setLoading(true);
		
				console.log(countryList);
			});
	}, []);

	useEffect(() => {
		setCountrySent(selectedCountry);
		console.log(countrySent);
	}, [selectedCountry]);


	if (loading === false) {
		return <></>;
	}
	if (listShown=== true){
		listToggle= "selection"
	}else{
		listToggle="selectionOff"
	}
	return (
		<>			
		<button className="Selection__title" onClick={showList}> Country List</button>
		<div className={listToggle}>
						{countryList.map((country) => (
							<button className="selection__button "
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
